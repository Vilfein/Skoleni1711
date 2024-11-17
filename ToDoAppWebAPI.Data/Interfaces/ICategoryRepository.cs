﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppWebAPI.Data.Models;

namespace ToDoAppWebAPI.Data.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<CategoryEntity>
    {
    }
}
