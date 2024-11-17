using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ToDoAppWebAPI.Data.Models;

namespace ToDoAppWebAPI.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        { }

        public DbSet<ToDoItemEntity>? ToDoItems { get; set; }
        public DbSet<CategoryEntity>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
            .Entity<ToDoItemEntity>()
            .HasOne(t => t.Category)
            .WithMany(c => c.ToDoItemEntities);




            IEnumerable<IMutableForeignKey> cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(type => type.GetForeignKeys())
                .Where(foreignKey => !foreignKey.IsOwnership && foreignKey.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var foreignKey in cascadeFKs)
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
