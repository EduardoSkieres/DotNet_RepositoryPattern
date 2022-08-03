using System;
using System.Threading.Tasks;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AulaRepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser()
        {
            var user = new User(Guid.NewGuid(), "Ed", "ed@email.com", 25);
            await _userRepository.AddAsync(user);
            return Ok(user);
        }
    }
}