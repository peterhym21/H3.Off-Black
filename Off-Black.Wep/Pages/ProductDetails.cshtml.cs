using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;

namespace Off_Black.Wep.Pages
{
    public class ProductDetailsModel : PageModel
    {

        private readonly ILogger<ProductDetailsModel> _logger;
        private readonly IProductService _productService;
        private readonly IOrderItemService _orderItemService;

        public ProductDetailsModel(ILogger<ProductDetailsModel> logger, IProductService productService, IOrderItemService orderItemService)
        {
            _logger = logger;
            _productService = productService;
            _orderItemService = orderItemService;
        }
        #region SESSION DEMO
        public const string SessionKeyLastReviewed = "_SeesionKey";
        public int? SessionInfo_LastReviewed { get; private set; }
        #endregion

        [BindProperty]
        public ProductDTO Product { get; set; }
        

        public async Task OnGet(int ProductId)
        {
            Product = await _productService.GetById(ProductId);
        }

        public async Task<IActionResult> OnPost()
        {
            List<OrderItemDTO> session = new List<OrderItemDTO>();
            #region SESSION 

            if (HttpContext.Session.GetString("_SeesionKey") != null)
            {
                session = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
                OrderItemDTO OrderItem = session.FirstOrDefault(o => o.FK_ProductID == Product.ProductID);

                if (OrderItem != null)
                {
                    OrderItem.Amount++;
                }
                else
                {
                    OrderItem = new OrderItemDTO();
                    OrderItem.Amount = 1;
                    OrderItem.FK_ProductID = Product.ProductID;
                    session.Add(OrderItem);
                }
            }
            else
            {
                OrderItemDTO OrderItem = new OrderItemDTO();
                OrderItem.Amount = 1;
                OrderItem.FK_ProductID = Product.ProductID;
                session.Add(OrderItem);
            }


            string sessionitem = JsonConvert.SerializeObject(session);

            HttpContext.Session.SetString(SessionKeyLastReviewed, sessionitem);
            #endregion

            return RedirectToPage("/Men/Men");
        }

    }
}
