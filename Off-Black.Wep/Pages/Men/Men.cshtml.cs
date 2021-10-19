using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;

namespace Off_Black.Wep.Pages
{
    public class MenModel : PageModel
    {
        private readonly ILogger<MenModel> _logger;
        private readonly IProductService _productService;

        public MenModel(ILogger<MenModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public List<ProductDTO> ProductDTOs { get; set; }
        public async Task OnGet()
        {
            ProductDTOs = await _productService.GetAllMen();

        }
    }
}
