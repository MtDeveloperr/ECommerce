using ECommerce.Catalog.DTOs.CategoryDtos;
using ECommerce.Catalog.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService, ICategoryService categoryService2)
        {
            _categoryService = categoryService;
            Console.WriteLine(categoryService.GetHashCode());
            Console.WriteLine(categoryService2.GetHashCode());
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var value = await _categoryService.GetCategoryByIdAsync(id);
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategoryById(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return Ok("Category Deleted Successfuly");
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return Ok("Category Inserted Successfuly");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Category Updated Successfuly");
        }
    }
}
