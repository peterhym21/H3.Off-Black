using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;

namespace Off_Black.Wep.Areas.Admin
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductService _productService;

        public IndexModel(ILogger<IndexModel> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public List<ProductDTO> ProductDTOs { get; set; }


        public async Task OnGetAsync()
        {
            ProductDTOs = await _productService.GetAll();
        }
    }
}
