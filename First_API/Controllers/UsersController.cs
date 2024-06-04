using First_API.Data;
using First_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private MyDbContext _context;

        public UsersController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(_context.Users.ToList());
        }
        [HttpPost]
        public IActionResult CreateUser(UsersModel model)
        {
            var users = new Users
            {
                Id = model.Id,
                UserName = model.UserName,
                Password = model.Password,
            };
            _context.Add(users);
            _context.SaveChanges();
            return Ok(users);
        }
    }
}
