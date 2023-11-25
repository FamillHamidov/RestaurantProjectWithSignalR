using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DataAccessLayer.EntityFramework;
using Restaurant.EntityLayer.Dtos.About;
using Restaurant.EntityLayer.Dtos.Product;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetList());
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new Context();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Name = y.Name,
                Description = y.Description,
                Price = y.Price,
                Status = y.Status,
                ImageUrl = y.ImageUrl,
                Id = y.Id,
                CategoryName = y.Category.Name
            }).ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductDto createProductDto)
        {
            Product product = _mapper.Map<Product>(createProductDto);
            _productService.TAdd(product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TRemove(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product product = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(product);
            return Ok();
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetById(id);
            return Ok(values);
        }
    }
}
