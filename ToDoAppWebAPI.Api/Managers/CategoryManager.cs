using AutoMapper;
using ToDoAppWebAPI.Api.Interfaces;
using ToDoAppWebAPI.Api.Models;
using ToDoAppWebAPI.Data.Interfaces;
using ToDoAppWebAPI.Data.Models;
using ToDoAppWebAPI.Data.Repositories;

namespace ToDoAppWebAPI.Api.Managers
{

    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO categoryDTO)
        {
            CategoryEntity categoryEntity = mapper.Map<CategoryEntity>(categoryDTO);
            categoryEntity.Id = default;
            CategoryEntity addedCategoryEntity = _categoryRepository.Insert(categoryEntity);
            return mapper.Map<CategoryDTO>(addedCategoryEntity);
        }

        public IList<CategoryDTO> GetAll()
        {
            IList<CategoryEntity> entities = _categoryRepository.GetAll();
            return mapper.Map<IList<CategoryDTO>>(entities);
        }
    }
}
