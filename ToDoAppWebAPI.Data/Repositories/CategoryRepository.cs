using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppWebAPI.Data.Interfaces;
using ToDoAppWebAPI.Data.Models;

namespace ToDoAppWebAPI.Data.Repositories
{
    public class CategoryRepository : BaseRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(ToDoDbContext toDoDbContext) : base(toDoDbContext)
        {
        }
    }
}
