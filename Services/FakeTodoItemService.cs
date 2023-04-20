using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using asp_net_core_todo.Models;

namespace asp_net_core_todo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Julie is Awesome sauce",
                DueAt = DateTimeOffset.Now.AddDays(6)          
            };

            return Task.FromResult(new[] {item1, item2 });
        }
    }
}