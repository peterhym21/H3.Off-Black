using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Services.Services
{
    public class OrderService : GenericService<OrderDTO, IOrderRepository, Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly MappingService _mappingService;
        public OrderService(IOrderRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _orderRepository = GenericRepository;
            _mappingService = mappingService;
        }

        public async Task CustomCreate(OrderDTO order)
        {
            try
            {
                _orderRepository.CustomCreate(_mappingService._mapper.Map<Order>(order));
                LogInformation($"Successfully Create a {order} ");
            }
            catch (Exception e)
            {
                LogError($"Failed to Create a {order} ", e);
            }
        }

        public async Task CustomUpdate(OrderDTO order)
        {
            try
            {
                await _orderRepository.CustomUpdate(_mappingService._mapper.Map<Order>(order));
                LogInformation($"Successfully Updated a {order} ");
            }
            catch (Exception e)
            {
                LogError($"Failed to Updated a {order} ", e);
            }
        }

        public async Task<OrderDTO> GetLastOrder()
        {
            try
            {
                OrderDTO order = _mappingService._mapper.Map<OrderDTO>(await _orderRepository.GetLastOrder());
                LogInformation($"Successfully fetched the Last Order");
                return order;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch the last Order", e);
                return null;
            }
        }

        public async Task SendEmail(OrderDTO order)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("SmtpclientPH.meh@gmail.com", "*rI#qkhfWf6EpoUJSak#a6SHdO$8pGS0EI%zHT57&oSf&^jJHX"),
                    EnableSsl = true
                };
                await client.SendMailAsync("SmtpclientPH.meh@gmail.com", order.Customer.Email, "Tak for din bestilling", $"Hej {order.Customer.FirstName} \n Tak fordi du har bestil dine vare ved os");

                LogInformation($"Successfully Send email");
            }
            catch (Exception e)
            {
                LogError($"Failed to send Email", e);
            }
        }
    }
}
