using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using System;

namespace Service.Services
{
    /// <summary>
    /// The MappingService. Used for Automapper so only 1 mapper is needed.
    /// </summary>
    public class MappingService : BaseService
    {
        public readonly AutoMapper.IMapper _mapper;
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingService"/> class.
        /// </summary>
        public MappingService()
        {
            AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
                // Class
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();

                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<CategoryDTO, Category>();

                cfg.CreateMap<Customer, CustomerDTO>();
                cfg.CreateMap<CustomerDTO, Customer>();

                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<OrderDTO, Order>();

                cfg.CreateMap<OrderItem, OrderItemDTO>();
                cfg.CreateMap<OrderItemDTO, OrderItem>();

                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<ProductDTO, Product>();

            });

            try
            {
                _mapper = mapperConfig.CreateMapper();
            }
            catch (Exception ex)
            {
                LogError("Failed to create mappings", ex);
            }

        }
    }
}
