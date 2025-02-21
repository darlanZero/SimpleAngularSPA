using Microsoft.EntityFrameworkCore;
using Namotion.Reflection;

namespace BackendSide.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItemModel> TodoItems { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItemModel>()
                .Property(t => t.Name)
                .IsRequired();

            modelBuilder.Entity<TodoItemModel>()
                .Property(t => t.DueDate)
                .IsRequired();
        }
    }
}