using Microsoft.AspNetCore.Mvc;

namespace RateLimitingMiddlewareDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Request successful!");
        }
    }
}