using Microsoft.AspNetCore.Mvc;
using ToDoAppWebAPI.Api.Interfaces;
using ToDoAppWebAPI.Api.Models;

namespace ToDoAppWebAPI.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        private readonly ITodoItemManager toDoItemManager;

        public ToDoItemController(ITodoItemManager toDoItemManager)
        {
            this.toDoItemManager = toDoItemManager;
        }

        [HttpGet("todoitems")]
        public IEnumerable<ToDoItemDTO> GetAll() => toDoItemManager.GetAll();
    }
}
