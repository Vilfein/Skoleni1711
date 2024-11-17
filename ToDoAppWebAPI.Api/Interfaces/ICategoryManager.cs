using ToDoAppWebAPI.Api.Models;

namespace ToDoAppWebAPI.Api.Interfaces
{
    public interface ICategoryManager
    {
        IList<CategoryDTO> GetAll();
        CategoryDTO Create(CategoryDTO categoryDTO);

    }
}
