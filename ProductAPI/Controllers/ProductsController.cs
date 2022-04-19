using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   [Authorize]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<string> {
        "Telefon", "Terlik", "Kalem", "Kağıt", "Ampul", "Kağıt"
      });
        }
    }
}
