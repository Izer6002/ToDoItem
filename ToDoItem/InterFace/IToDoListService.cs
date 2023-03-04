using Microsoft.AspNetCore.Mvc;
using ToDoItem.DataBase.Entity;

namespace ToDoItem.InterFace
{
    public interface IToDoListService
    {
        Task<ToDo> Read(int id);
        Task<ToDo> Change(int id, string text);
        Task<IActionResult> Delete(int id);
        Task<IActionResult> Create(ToDo entity);
    }
}
