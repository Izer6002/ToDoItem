using Microsoft.AspNetCore.Mvc;
using ToDoItem.DataBase.Context;
using ToDoItem.DataBase.Entity;
using ToDoItem.InterFace;

namespace ToDoItem.Services
{
    public class ToDoListService : IToDoListService
    {
        private readonly ToDoDBContext db;
        public ToDoListService(ToDoDBContext db)
        {
            this.db = db;
        }
        private readonly IToDoListService bookService;

        public async Task<ToDo> Change(int id, string text)
        {
            
        }

        public async Task<IActionResult> Create(ToDo entity)
        {
            db.ToDoList.Add(entity);
            await db.SaveChangesAsync();
            return new OkObjectResult(entity);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await db.ToDoList.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }

            db.ToDoList.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        public Task<ToDo> Read(int id)
        {
            throw new NotImplementedException();
        }

    }
}
