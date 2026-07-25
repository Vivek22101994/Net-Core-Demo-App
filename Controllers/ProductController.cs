using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [OutputCache(Duration = 500)]
        public IActionResult Get()
        {
            Console.WriteLine("Database Hit");

            return Ok(new
            {
                Time = DateTime.Now,
            });
        }
    }
}
