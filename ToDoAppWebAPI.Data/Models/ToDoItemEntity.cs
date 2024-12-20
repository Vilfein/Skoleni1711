﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAppWebAPI.Data.Models
{
    public class ToDoItemEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }

        [ForeignKey(nameof(Category))]
        public uint? CategoryId { get; set; }

        public virtual CategoryEntity? Category
        {
            get; set;
        }
    }
}
