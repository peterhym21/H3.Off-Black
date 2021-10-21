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
    public class CartModel : PageModel
    {
        private readonly ILogger<CartModel> _logger;
        private readonly IProductService _productService;
        private readonly IOrderItemService _orderItemService;

        public CartModel(ILogger<CartModel> logger, IProductService productService, IOrderItemService orderItemService)
        {
            _logger = logger;
            _productService = productService;
            _orderItemService = orderItemService;
        }
        public const string SessionKeyLastReviewed = "_SeesionKey";

        [BindProperty]
        public int ProductId { get; set; }
        [BindProperty (SupportsGet = true)]
        public int Amount { get; set; }
        [BindProperty(SupportsGet = true)]
        public OrderDTO CartItems { get; set; } = new OrderDTO();

        public void OnGet()
        {
            CartItems.OrderItems = new List<OrderItemDTO>();
            CartItems.OrderItems = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
            foreach (var item in CartItems.OrderItems)
            {
                if (item.Amount > 1)
                {
                    for (int i = 0; i < item.Amount; i++)
                    {
                        CartItems.TotalPrice += item.Product.Price;
                    }
                }
                else
                {
                    CartItems.TotalPrice += item.Product.Price;
                }
                
            }

        }

        public async Task OnPost()
        {

        }

        public async Task<IActionResult> OnPostUpdate()
        {
            List<OrderItemDTO> session = new List<OrderItemDTO>();
            OrderItemDTO sessionItem = null;
            #region SESSION 
            session = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
            sessionItem = session.FirstOrDefault(o => o.FK_ProductID == ProductId);
            if (sessionItem != null)
            {
                sessionItem.Amount = Amount;
            }
            if (Amount == 0)
            {
                session.Remove(sessionItem);
            }
            

            string sessionitems = JsonConvert.SerializeObject(session);
            HttpContext.Session.SetString(SessionKeyLastReviewed, sessionitems);
            #endregion
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDelete()
        {
            List<OrderItemDTO> session = new List<OrderItemDTO>();
            OrderItemDTO sessionItem = null;
            #region SESSION 
            session = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
            sessionItem = session.FirstOrDefault(o => o.FK_ProductID == ProductId);
            if (sessionItem != null)
            {
                session.Remove(sessionItem);
            }
            string sessionitems = JsonConvert.SerializeObject(session);
            HttpContext.Session.SetString(SessionKeyLastReviewed, sessionitems);
            #endregion

            return RedirectToPage();
        }

    }
}
