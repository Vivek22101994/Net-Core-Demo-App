using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("fixed")]
    public class RateLimitTest : Controller
    {
        public IActionResult Index()
        {
            return Ok(true);
        }
    }
}
