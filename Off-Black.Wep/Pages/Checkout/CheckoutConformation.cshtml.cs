using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    public class CheckoutConformationModel : PageModel
    {
        private readonly ILogger<CheckoutConformationModel> _logger;
        private readonly IProductService _productService;
        private readonly IOrderItemService _orderItemService;
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;


        public CheckoutConformationModel(ILogger<CheckoutConformationModel> logger, IProductService productService, IOrderItemService orderItemService, IOrderService orderService, ICustomerService customerService)
        {
            _logger = logger;
            _productService = productService;
            _orderItemService = orderItemService;
            _orderService = orderService;
            _customerService = customerService;
        }
        public const string SessionKeyLastReviewed = "_SeesionKey";

        [BindProperty(SupportsGet = true)]
        public OrderDTO Order { get; set; } 

        [BindProperty(SupportsGet = true)]
        public CustomerDTO Customer { get; set; }


        public async Task OnGet()
        {
            #region Delete Session / cart
            List<OrderItemDTO> session = null;
            string sessionitems = JsonConvert.SerializeObject(session);
            HttpContext.Session.SetString(SessionKeyLastReviewed, sessionitems);
            #endregion
            Order = await _orderService.GetLastOrder();

            await _orderService.SendEmail(Order);

        }
    }
}
