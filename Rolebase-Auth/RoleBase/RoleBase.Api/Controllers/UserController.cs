using Microsoft.AspNetCore.Mvc;
using RoleBase.Application.Interfaces;

namespace RoleBase.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok("User Controller");
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok($"Get User By Id: {id}");
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser()
        {
            return Ok("Create User");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser()
        {
            return Ok("Update User");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser()
        {
            return Ok("Delete User");
        }
    }
}
