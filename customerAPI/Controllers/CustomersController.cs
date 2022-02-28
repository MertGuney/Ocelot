using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace customerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<string> { "Hilmi Celayir", "Saniye Yıldız", "Nevin Yıldız", "Fatih Yılmaz" });
        }
    }
}
