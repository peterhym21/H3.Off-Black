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

        [BindProperty]
        public string SeachTearm { get; set; }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 2;
        public List<ProductDTO> ProductDTOs { get; set; }

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public async Task OnGetAsync()
        {
            ProductDTOs = await _productService.GetPaginatedResultMen(CurrentPage, PageSize);
            Count = await _productService.GetCountMen();
        }
        public async Task OnPostAsync()
        {
            ProductDTOs = await _productService.GetAllBySeachTearm(SeachTearm);

        }


    }
}
