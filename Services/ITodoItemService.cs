using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using asp_net_core_todo.Models;

namespace asp_net_core_todo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}