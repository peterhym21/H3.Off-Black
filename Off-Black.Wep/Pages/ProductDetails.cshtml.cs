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
        public const string SessionKeyLastReviewed = "_SeesionKey";

        [BindProperty]
        public ProductDTO Product { get; set; }
        

        public async Task OnGet(int ProductId)
        {
            Product = await _productService.GetById(ProductId);
        }

        public async Task<IActionResult> OnPost()
        {
            List<OrderItemDTO> session = new List<OrderItemDTO>();
            OrderItemDTO sessionItem = null;
            #region SESSION 

            if (HttpContext.Session.GetString("_SeesionKey") != null)
            {
                session = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
                sessionItem = session.FirstOrDefault(o => o.FK_ProductID == Product.ProductID);

                if (sessionItem != null)
                {
                    sessionItem.Amount++;
                }
            }
            if (sessionItem == null)
            {
                session.Add(new OrderItemDTO()
                {
                    Amount = 1,
                    FK_ProductID = Product.ProductID,
                    Product = Product
                }); ;
            }
            string sessionitem = JsonConvert.SerializeObject(session);

            HttpContext.Session.SetString(SessionKeyLastReviewed, sessionitem);
            #endregion

            if (Product.Gender)
            {
                return RedirectToPage("/Woman/Woman");
            }
            else
            {
                return RedirectToPage("/Men/Men");
            }
            
        }

    }
}
