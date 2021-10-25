using Microsoft.AspNetCore.Mvc;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #region Men

        [HttpGet]
        [Route("/AllMen")]
        public async Task<List<ProductDTO>> GetAllMen()
        {
            return await _productService.GetAllMen();
        }

        [HttpGet]
        [Route("/AllMenByCategory")]
        public async Task<List<ProductDTO>> GetAllMenByCategory()
        {
            return await _productService.GetAllMenByCategory(3);
        }

        [HttpGet]
        [Route("/AllManPaged")]
        public async Task<List<ProductDTO>> GetAllManPaged()
        {
            return await _productService.GetPaginatedResultMen(1, 2);
        }
        [HttpGet]
        [Route("/AllCountMen")]
        public async Task<int> GetCountMen()
        {
            return await _productService.GetCountMen();
        }

        #endregion

        #region Woman

        [HttpGet]
        [Route("/AllWoman")]
        public async Task<List<ProductDTO>> GetAllWoman()
        {
            return await _productService.GetAllWoman();
        }

        [HttpGet]
        [Route("/AllWomanByCategory")]
        public async Task<List<ProductDTO>> GetAllWomanByCategory()
        {
            return await _productService.GetAllWomanByCategory(3);
        }

        [HttpGet]
        [Route("/AllWomanPaged")]
        public async Task<List<ProductDTO>> GetAllWomanPaged()
        {
            return await _productService.GetPaginatedResultWoman(1, 2);
        }

        [HttpGet]
        [Route("/AllCountWoman")]
        public async Task<int> GetCountWoman()
        { 
            return await _productService.GetCountWoman();
        }

        #endregion

        #region gets


        [HttpGet]
        [Route("/ByIdProduct")]
        public async Task<ProductDTO> GetById()
        {
            return await _productService.GetById(2);
        }

        [HttpGet]
        [Route("/AllBySearchTearmProduct")]
        public async Task<List<ProductDTO>> GetAllBySearchTearm()
        {
            return await _productService.GetAllBySeachTearm("p");
        }

        [HttpGet]
        [Route("/AllFiltersProducts")]
        public async Task<List<ProductDTO>> GetAllByAllFilters()
        {
            return await _productService.GetAllByAllFilters("p", 1, 2);
        }

        [HttpGet]
        [Route("/AllProductsByCategory")]
        public async Task<List<ProductDTO>> GetAllByCategory()
        {
            return await _productService.GetAllByCategory(1);
        }

        [HttpGet]
        [Route("/AllSortedPriceASCProducts")]
        public async Task<List<ProductDTO>> GetAllSortetPriceASC()
        {
            return await _productService.GetAllSortetPriceASC();
        }

        [HttpGet]
        [Route("/AllSortedPriceDESCProducts")]
        public async Task<List<ProductDTO>> GetAllSortetPriceDESC()
        {
            return await _productService.GetAllSortetPriceDESC();
        }

        [HttpGet]
        [Route("/AllProductCount")]
        public async Task<int> GetCountAll()
        {
            return await _productService.GetCountAll("p");
        }

        #endregion


        [HttpGet]
        [Route("/AllProduct")]
        public async Task<List<ProductDTO>> GetAll()
        {
            return await _productService.GetAll();
        }


        [HttpPost]
        [Route("/CreateProduct")]
        public async Task CreateNewProduct()
        {
            ProductDTO product = new ProductDTO();

            await _productService.Create(product);
        }

        [HttpPut]
        [Route("/UpdateProduct")]
        public async Task Update()
        {
            ProductDTO product = new ProductDTO();
            await _productService.Update(product);
        }

        [HttpPut]
        [Route("/DeleteProduct")]
        public async Task Delete()
        {
            ProductDTO product = new ProductDTO();
            await _productService.Delete(product);
        }
    }
}
