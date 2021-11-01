using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;

namespace Off_Black.Wep.Pages.Men
{
    public class JacketsModel : PageModel
    {
        private readonly ILogger<JacketsModel> _logger;
        private readonly IProductService _productService;

        public JacketsModel(ILogger<JacketsModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public List<ProductDTO> ProductDTOs { get; set; }

        public async Task OnGet(int CategoryId)
        {
            ProductDTOs = await _productService.GetAllMenByCategory(CategoryId);
        }
    }
}
