using Microsoft.AspNetCore.Mvc;
using WebAPI.Models.Categories;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private ICategoriesService _categoriesService;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(
            ICategoriesService categoriesService,
            ILogger<CategoriesController> logger
            )
        {
            _categoriesService = categoriesService;
            _logger = logger;   
        }

        [HttpGet(Name = "GetCategories")]
        public async Task<List<CategoriesResponse>> GetCategories()
        {
            var categories = await _categoriesService.GetCategories();

            return categories;     
        }
    }
}
