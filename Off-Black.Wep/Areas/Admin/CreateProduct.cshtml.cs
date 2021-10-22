using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;

namespace Off_Black.Wep.Areas.Admin
{
    public class CreateProductModel : PageModel
    {
        private readonly ILogger<CreateProductModel> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public CreateProductModel(ILogger<CreateProductModel> logger, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }

        [BindProperty (SupportsGet = true)]
        public ProductDTO ProductDTOs { get; set; }



        public void OnGet()
        {
        }
    }
}
