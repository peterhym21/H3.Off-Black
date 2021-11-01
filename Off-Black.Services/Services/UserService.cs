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
