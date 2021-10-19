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

        public List<OrderItemDTO> CartItems { get; set; }

        public void OnGet()
        {
            CartItems = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));

        }
    }
}
