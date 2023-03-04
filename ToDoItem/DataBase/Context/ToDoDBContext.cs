using Microsoft.EntityFrameworkCore;
using ToDoItem.DataBase.Entity;

namespace ToDoItem.DataBase.Context
{
    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ToDo> ToDoList { get; set; }

    }
}
