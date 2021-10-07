using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using Service.Services;

namespace Off_Black.Services.Services
{
    public class ProductService : GenericService<ProductDTO, IProductRepository, Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly MappingService _mappingService;
        public ProductService(IProductRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _productRepository = GenericRepository;
            _mappingService = mappingService;
        }
    }
}
