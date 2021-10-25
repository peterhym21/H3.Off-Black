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
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("/AllUser")]
        public async Task<List<UserDTO>> GetAll()
        {
            return await _userService.GetAll();
        }

        [HttpPost]
        [Route("/CreateUser")]
        public async Task Create()
        {
            UserDTO user = new UserDTO();
            await _userService.Create(user);
        }

        [HttpPut]
        [Route("/DeleteUser")]
        public async Task Delete()
        {
            UserDTO user = new UserDTO();
            await _userService.Delete(user);
        }

        [HttpPut]
        [Route("/UpdateUser")]
        public async Task Update( )
        {
            UserDTO user = new UserDTO();
            await _userService.Update(user);
        }
    }
}
