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
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("AllMen")]
        public async Task<List<ProductDTO>> GetAllMen()
        {
            return await _productService.GetAllMen();
        }

        [HttpGet]
        [Route("AllWoman")]
        public async Task<List<ProductDTO>> GetAllWoman()
        {
            return await _productService.GetAllWoman();
        }
    }
}
