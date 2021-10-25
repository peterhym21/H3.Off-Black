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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("/AllCategory")]
        public async Task<List<CategoryDTO>> GetAll()
        {
            return await _categoryService.GetAll();
        }

        [HttpPost]
        [Route("/CreateCategory")]
        public async Task Create(CategoryDTO category)
        {
            await _categoryService.Create(category);
        }

        [HttpPut]
        [Route("/UpdateCategory")]
        public async Task Update(CategoryDTO category)
        {
            await _categoryService.Update(category);
        }

        [HttpPut]
        [Route("/DeleteCategory")]
        public async Task Delete(CategoryDTO category)
        {
            await _categoryService.Delete(category);
        }

    }
}
