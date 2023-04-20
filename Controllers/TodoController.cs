using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp_net_core_todo.Services;
using asp_net_core_todo.Models;

namespace asp_net_core_todo.Controllers
{
    public class TodoController : Controller
    {

        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        // Actions go here
        public async Task<IActionResult> Index()
        {
            // get items from a database
            var items = await _todoItemService.GetIncompleteItemsAsync();

            // Put items into a model
            var model = new TodoViewModel()
            {
                Items = items
            };

            // Render view using a model
            return View(model);
        }
    }    
}