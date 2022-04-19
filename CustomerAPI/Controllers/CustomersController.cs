using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<string> {
         "Hilmi", "Hüseyin", "Rıfkı", "Necati", "Şuayip", "Muallim", "Muiddin"
      });
        }
    }
}
