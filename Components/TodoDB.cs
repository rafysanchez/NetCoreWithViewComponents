using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreComponent.Data;
using NetCoreComponent.Models;

namespace NetCoreComponent.Components
{

    public class TodoDb : ViewComponent
    {
        private readonly ApplicationDbContext db;

        public TodoDb(ApplicationDbContext context) => this.db = context;

        public async Task<IViewComponentResult> InvokeAsync(bool done)
        {
            var items = await GetItemsAsync(done);
            return View(items);
        }


        private Task<List<TodoList>> GetItemsAsync(bool done) => db.TodoList.Where(a => a.done == done).ToListAsync();


    }
}