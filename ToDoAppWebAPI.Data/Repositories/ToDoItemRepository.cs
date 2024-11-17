using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppWebAPI.Data.Interfaces;
using ToDoAppWebAPI.Data.Models;

namespace ToDoAppWebAPI.Data.Repositories
{
    public class ToDoItemRepository : BaseRepository<ToDoItemEntity>, ITodoItemRepository
    {
        public ToDoItemRepository(ToDoDbContext toDoDbContext) : base(toDoDbContext)
        {
        }
    }
}
