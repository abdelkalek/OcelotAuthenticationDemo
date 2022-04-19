using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        IConfiguration _configuration;
        public AuthsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("{userName}/{password}")]
        public IActionResult Login(string userName, string password)
        {
            TokenHandler._configuration = _configuration;
            return Ok(userName == "gncy" && password == "12345" ? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
        }
    }
}
