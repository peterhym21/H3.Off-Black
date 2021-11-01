using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;

namespace Off_Black.Wep.Pages.Checkout
{
    public class CustomerInfoModel : PageModel
    {
        private readonly ILogger<CustomerInfoModel> _logger;
        private readonly IProductService _productService;
        private readonly IOrderItemService _orderItemService;
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;


        public CustomerInfoModel(ILogger<CustomerInfoModel> logger, IProductService productService, IOrderItemService orderItemService, IOrderService orderService, ICustomerService customerService)
        {
            _logger = logger;
            _productService = productService;
            _orderItemService = orderItemService;
            _orderService = orderService;
            _customerService = customerService;
        }
        public const string SessionKeyLastReviewed = "_SeesionKey";

        [BindProperty(SupportsGet = true)]
        public OrderDTO Order { get; set; } = new OrderDTO();
        [BindProperty(SupportsGet = true)]
        public CustomerDTO Customer { get; set; }


        public void OnGet()
        {
            Order.OrderItems = new List<OrderItemDTO>();
            Order.OrderItems = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
            foreach (var item in Order.OrderItems)
            {
                if (item.Amount > 1)
                {
                    for (int i = 0; i < item.Amount; i++)
                    {
                        Order.TotalPrice += item.Product.Price;
                    }
                }
                else
                {
                    Order.TotalPrice += item.Product.Price;
                }

            }
        }

        public async Task<IActionResult> OnPost()
        {
            Order.OrderItems = JsonConvert.DeserializeObject<List<OrderItemDTO>>(HttpContext.Session.GetString("_SeesionKey"));
            foreach (var item in Order.OrderItems)
            {
                if (item.Amount > 1)
                {
                    for (int i = 0; i < item.Amount; i++)
                    {
                        Order.TotalPrice += item.Product.Price;
                    }
                }
                else
                {
                    Order.TotalPrice += item.Product.Price;
                }
            }
            Order.OrderDate = DateTime.UtcNow;
            Order.Customer = Customer;
            await _orderService.CustomCreate(Order);
            return RedirectToPage("../Checkout/CheckoutConformation");
        }

    }
}
