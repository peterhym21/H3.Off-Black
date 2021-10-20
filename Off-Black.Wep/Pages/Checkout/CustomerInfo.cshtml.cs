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

namespace Off_Black.Wep.Pages.Checkout
{
    public class CustomerInfoModel : PageModel
    {
        private readonly ILogger<CustomerInfoModel> _logger;
        private readonly IProductService _productService;
        private readonly IOrderItemService _orderItemService;

        public CustomerInfoModel(ILogger<CustomerInfoModel> logger, IProductService productService, IOrderItemService orderItemService)
        {
            _logger = logger;
            _productService = productService;
            _orderItemService = orderItemService;
        }
        public const string SessionKeyLastReviewed = "_SeesionKey";

        [BindProperty(SupportsGet = true)]
        public OrderDTO CartItems { get; set; } = new OrderDTO();
        [BindProperty(SupportsGet = true)]
        public CustomerDTO Customer { get; set; }


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

    }
}
