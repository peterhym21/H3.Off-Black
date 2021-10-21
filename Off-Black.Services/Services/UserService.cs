using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Services.Services
{
    public class UserService : GenericService<UserDTO, IUserRepository, User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly MappingService _mappingService;
        public UserService(IUserRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _userRepository = GenericRepository;
            _mappingService = mappingService;
        }
    }
}
