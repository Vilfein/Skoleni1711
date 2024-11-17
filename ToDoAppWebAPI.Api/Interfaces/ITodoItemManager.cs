using ToDoAppWebAPI.Api.Models;

namespace ToDoAppWebAPI.Api.Interfaces
{
    public interface ITodoItemManager
    {
        IList<ToDoItemDTO> GetAll();
    }
}
