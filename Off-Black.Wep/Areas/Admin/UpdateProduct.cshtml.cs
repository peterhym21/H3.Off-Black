using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;

namespace Off_Black.Wep.Areas.Admin
{
    public class UpdateProductModel : PageModel
    {
        private readonly ILogger<UpdateProductModel> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public UpdateProductModel(ILogger<UpdateProductModel> logger, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }

        [BindProperty(SupportsGet = true)]
        public ProductDTO ProductDTOs { get; set; }
        public void OnGet()
        {
        }
    }
}
