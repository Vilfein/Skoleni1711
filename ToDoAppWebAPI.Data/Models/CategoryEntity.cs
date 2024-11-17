using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAppWebAPI.Data.Models
{
    public class CategoryEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public uint Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }


        public virtual List<ToDoItemEntity> ToDoItemEntities { get; set; } = new
         List<ToDoItemEntity>();

    }
}
