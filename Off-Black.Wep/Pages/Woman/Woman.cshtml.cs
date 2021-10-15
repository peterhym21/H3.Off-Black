using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;

namespace Off_Black.Wep.Pages.Woman
{
    public class WomanModel : PageModel
    {
        private readonly ILogger<WomanModel> _logger;
        private readonly IProductService _productService;

        public WomanModel(ILogger<WomanModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public List<ProductDTO> ProductDTOs { get; set; }
        public async Task OnGet()
        {
            ProductDTOs = await _productService.GetAllWoman();

        }
    }
}
