using AutoMapper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Off_Black.Wep.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public IndexModel(ILogger<IndexModel> logger, ICategoryService categoryService, IProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }

        [BindProperty (SupportsGet = true)]
        public string SearchTerm { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PriceFilter { get; set; }
        [BindProperty (SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        [BindProperty (SupportsGet = true)]
        public int PageSize { get; set; } = 2;
        [BindProperty(SupportsGet = true)]
        public List<ProductDTO> ProductDTOs { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<CategoryDTO> CategoryDTO { get; set; }

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public enum PageSizeEnum
        {
            [Display(Name = "2")]
            _2 = 2,
            [Display(Name = "5")]
            _5 = 5,
            [Display(Name = "10")]
            _10 = 10,
            [Display(Name = "15")]
            _15 = 15
        }



        public async Task OnGetAsync()
        {
            CategoryDTO = await _categoryService.GetAll();
            if (SearchTerm != null)
            {
                ProductDTOs = await _productService.GetAllByAllFilters(SearchTerm, CurrentPage, PageSize);
                Count = await _productService.GetCountAll(SearchTerm);
            }
        }

        public async Task OnPost()
        {
            if (SearchTerm != null)
            {
                ProductDTOs = await _productService.GetAllByAllFilters(SearchTerm, CurrentPage, PageSize);
                Count = await _productService.GetCountAll(SearchTerm);
            }
            //if (PriceFilter == "Low-High")
            //{
            //    ProductDTOs = await _productService.GetAllSortetPriceASC();
            //}
            //if (PriceFilter == "High-Low")
            //{
            //    ProductDTOs = await _productService.GetAllSortetPriceDESC();
            //}

            CategoryDTO = await _categoryService.GetAll();
        }

    }
}
