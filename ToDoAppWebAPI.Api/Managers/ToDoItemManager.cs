using AutoMapper;
using ToDoAppWebAPI.Api.Interfaces;
using ToDoAppWebAPI.Api.Models;
using ToDoAppWebAPI.Data.Interfaces;
using ToDoAppWebAPI.Data.Models;

namespace ToDoAppWebAPI.Api.Managers
{
    public class ToDoItemManager : ITodoItemManager
    {
        private readonly ITodoItemRepository todoItemRepository;
        private readonly IMapper mapper;

        public ToDoItemManager(ITodoItemRepository todoItemRepository, IMapper mapper)
        {
            this.todoItemRepository = todoItemRepository;
            this.mapper = mapper;
        }

        public ToDoItemDTO Create(ToDoItemDTO toDoItemDTO)
        {
            var dto = todoItemRepository.Insert(mapper.Map<ToDoItemEntity>(toDoItemDTO));
            return mapper.Map<ToDoItemDTO>(dto);
        }

        public IList<ToDoItemDTO> GetAll()
        {
            IList<ToDoItemEntity> todoEntities = todoItemRepository.GetAll();
            return mapper.Map<IList<ToDoItemDTO>>(todoEntities); 
        }

        
    }
}
