using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace productAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Product> products = new()
            {
                new Product() { Id = 1, Name = "Kalem" },
                new Product() { Id = 2, Name = "Kitap" }
            };
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            List<Product> products = new()
            {
                new Product() { Id = 1, Name = "Kalem" },
                new Product() { Id = 2, Name = "Kitap" }
            };

            return Ok(products[id - 1]);
        }
    }
}
