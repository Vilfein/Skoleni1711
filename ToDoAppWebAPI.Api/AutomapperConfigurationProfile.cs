using AutoMapper;
using ToDoAppWebAPI.Api.Models;
using ToDoAppWebAPI.Data.Models;

namespace ToDoAppWebAPI.Api
{
    public class AutomapperConfigurationProfile : Profile
    {
        public AutomapperConfigurationProfile()
        {

            CreateMap<ToDoItemEntity, ToDoItemDTO>();
            CreateMap<ToDoItemDTO, ToDoItemEntity>();

        }
    }
}
