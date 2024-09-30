using Microsoft.AspNetCore.Mvc;
using NiceHouse.Models;
using NiceHouse.Services;

namespace NiceHouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // API lấy tất cả sản phẩm
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        // API lấy sản phẩm theo ID
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // API thêm sản phẩm mới
        [HttpPost]
        public IActionResult AddProduct([FromBody] Products product)
        {
            _productService.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
        }

        // API cập nhật sản phẩm
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Products product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }
            _productService.UpdateProduct(product);
            return NoContent();
        }

        // API xóa sản phẩm theo ID
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }

        // API tìm kiếm sản phẩm theo khoảng giá, số phòng, địa chỉ và trạng thái cho thuê
        [HttpGet("search")]
        public IActionResult SearchProducts([FromQuery] float maxRent, [FromQuery] float maxPrice, [FromQuery] int rooms, [FromQuery] string? address, [FromQuery] bool isRent)
        {
            var products = _productService.SearchProducts(maxRent, maxPrice, rooms, address, isRent);
            return Ok(products);
        }
    }

}
