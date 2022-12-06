using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // just like /api/users
    public class UsersController
    {
         
        private readonly DataContext _context;

        public UsersController(DataContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            // var user = this.context.Users.Find(id);
            // return user; or this below

            return await _context.Users.FindAsync(id);
        }

    }
}