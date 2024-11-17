using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAppWebAPI.Api.Interfaces;
using ToDoAppWebAPI.Api.Models;

namespace ToDoAppWebAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        [HttpGet]
        public IEnumerable<CategoryDTO> GetAll()
        {
            return categoryManager.GetAll();
        }

        [HttpPost]
        public CategoryDTO Create([FromBody] CategoryDTO data)
        {
            return categoryManager.Create(data);
        }

    }
}
