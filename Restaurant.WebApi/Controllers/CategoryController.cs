using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DataAccessLayer.EntityFramework;
using Restaurant.EntityLayer.Dtos.About;
using Restaurant.EntityLayer.Dtos.Category;
using Restaurant.EntityLayer.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetList());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCategory(CreateCategoryDto createCategoryDto)
        {
            Category category= _mapper.Map<Category>(createCategoryDto);
            _categoryService.TAdd(category);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TRemove(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbut(UpdateAboutDto updateAboutDto)
        {
            Category category= _mapper.Map<Category>(updateAboutDto);
            _categoryService.TUpdate(category);
            return Ok();
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            return Ok(values);
        }
    }
}
