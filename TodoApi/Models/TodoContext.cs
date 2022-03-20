using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        private static bool _created = false;
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}