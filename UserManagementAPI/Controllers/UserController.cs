using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Model;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController :ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll() => _userService.GetAll();

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Create(user);
                return Ok(user);
            }
            return BadRequest();
        }
    }
}
