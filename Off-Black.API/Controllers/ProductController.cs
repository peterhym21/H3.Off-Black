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
        [Route("/AllMenByCategory{Id:int}")]
        public async Task<List<ProductDTO>> GetAllMenByCategory(int Id)
        {
            return await _productService.GetAllMenByCategory(Id);
        }

        [HttpGet]
        [Route("/AllManPaged/{CurrentPage:int}/{PageSize:int}")]
        public async Task<List<ProductDTO>> GetAllManPaged(int CurrentPage, int PageSize)
        {
            return await _productService.GetPaginatedResultMen(CurrentPage, PageSize);
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
        [Route("/AllWomanByCategory/{Id:int}")]
        public async Task<List<ProductDTO>> GetAllWomanByCategory(int Id)
        {
            return await _productService.GetAllWomanByCategory(Id);
        }

        [HttpGet]
        [Route("/AllWomanPaged/{CurrentPage:int}/{PageSize:int}")]
        public async Task<List<ProductDTO>> GetAllWomanPaged(int CurrentPage, int PageSize)
        {
            return await _productService.GetPaginatedResultWoman(CurrentPage, PageSize);
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
        [Route("/ByIdProduct/{Id:int}")]
        public async Task<ProductDTO> GetById(int Id)
        {
            return await _productService.GetById(Id);
        }

        [HttpGet]
        [Route("/AllBySearchTearmProduct/{SeachTearm:string}")]
        public async Task<List<ProductDTO>> GetAllBySearchTearm(string SeachTearm)
        {
            return await _productService.GetAllBySeachTearm(SeachTearm);
        }

        [HttpGet]
        [Route("/AllFiltersProducts/{SeachTearm:string}/{CurrentPage:int}/{PageSize:int}")]
        public async Task<List<ProductDTO>> GetAllByAllFilters(string SeachTearm, int CurrentPage, int PageSize)
        {
            return await _productService.GetAllByAllFilters(SeachTearm, CurrentPage, PageSize);
        }

        [HttpGet]
        [Route("/AllProductsByCategory/{Id:int}")]
        public async Task<List<ProductDTO>> GetAllByCategory(int Id)
        {
            return await _productService.GetAllByCategory(Id);
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
        public async Task CreateNewProduct(ProductDTO product)
        {
            await _productService.Create(product);
        }

        [HttpPut]
        [Route("/UpdateProduct")]
        public async Task Update(ProductDTO product)
        {
            await _productService.Update(product);
        }

        [HttpPut]
        [Route("/DeleteProduct")]
        public async Task Delete(ProductDTO product)
        {
            await _productService.Delete(product);
        }
    }
}
