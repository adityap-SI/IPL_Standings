using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

  
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Welcome()
        {
            return "Hello World";
        }
        [HttpGet("display")]
        public string Display()
        {
            return "Hello from Display";
        }
    }
}
