using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Service.Services
{
    public class CategoryService : GenericService<CategoryDTO, ICategoryRepository, Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly MappingService _mappingService;
        public CategoryService(ICategoryRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _categoryRepository = GenericRepository;
            _mappingService = mappingService;
        }
    }
}

