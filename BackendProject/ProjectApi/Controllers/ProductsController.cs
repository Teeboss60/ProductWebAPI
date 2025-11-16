
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new List<Product>();
        private static int _id = 1;

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_products);
        }

        [HttpPost]
        public ActionResult<Product> Add()
        {
            var newProduct = new Product
            {
                Id = _id++,
                ProductID = $"P{DateTime.Now.Ticks}"
            };

            _products.Add(newProduct);
            return Ok(newProduct);
        }
    }
}



