using ToDoAppWebAPI.Api.Models;

namespace ToDoAppWebAPI.Api.Interfaces
{
    public interface ITodoItemManager
    {
        IList<ToDoItemDTO> GetAll();

        ToDoItemDTO Create(ToDoItemDTO toDoItemDTO);

    }
}
