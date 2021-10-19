using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<List<ProductDTO>> GetAllMen()
        {
            try
            {
                List<ProductDTO> products = _mappingService._mapper.Map<List<ProductDTO>>(await _productRepository.GetAllMen());
                LogInformation($"Successfully fetched a list of Products Where gender = False");
                return products;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of Products", e);
                return new List<ProductDTO>();
            }
        }

        public async Task<List<ProductDTO>> GetAllMenByCategory(int Id)
        {
            try
            {
                List<ProductDTO> products = _mappingService._mapper.Map<List<ProductDTO>>(await _productRepository.GetAllMenByCategory(Id));
                LogInformation($"Successfully fetched a list of Products Where gender = False and CategoryId = Id: {Id}");
                return products;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of Products", e);
                return new List<ProductDTO>();
            }
        }


        public async Task<List<ProductDTO>> GetAllWoman()
        {
            try
            {
                List<ProductDTO> products = _mappingService._mapper.Map<List<ProductDTO>>(await _productRepository.GetAllWoman());
                LogInformation($"Successfully fetched a list of Products Where gender = true");
                return products;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of Products", e);
                return new List<ProductDTO>();
            }
        }

        public async Task<List<ProductDTO>> GetAllWomanByCategory(int Id)
        {
            try
            {
                List<ProductDTO> products = _mappingService._mapper.Map<List<ProductDTO>>(await _productRepository.GetAllWomanByCategory(Id));
                LogInformation($"Successfully fetched a list of Products Where gender = False and CategoryId = Id: {Id}");
                return products;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of Products", e);
                return new List<ProductDTO>();
            }
        }

        public async Task<List<ProductDTO>> GetAllSortetPrice()
        {
            try
            {
                List<ProductDTO> products = _mappingService._mapper.Map<List<ProductDTO>>(await _productRepository.GetAllSortetPrice());
                LogInformation($"Successfully fetched a list of Products");
                return products;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of Products", e);
                return new List<ProductDTO>();
            }
        }

        public async Task<ProductDTO> GetById(int id)
        {
            if (id == 0)
            {
                LogInformation($"Skipped fecthing the site because siteId was 0");
                return null;
            }
            try
            {
                ProductDTO product = _mappingService._mapper.Map<ProductDTO>(await _productRepository.GetById(id));
                LogInformation($"Successfully fetched the site with the id: ({id})");
                return product;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch the site with the id: ({id})", e);
                return null;
            }
        }
        public async Task<List<ProductDTO>> GetAllByCategory(int Id)
        {
            try
            {
                List<ProductDTO> products = _mappingService._mapper.Map<List<ProductDTO>>(await _productRepository.GetAllByCategory(Id));
                LogInformation($"Successfully fetched a list of Products Where gender = False and CategoryId = Id: {Id}");
                return products;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of Products", e);
                return new List<ProductDTO>();
            }
        }

    }
}
