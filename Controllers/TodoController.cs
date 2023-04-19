using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_todo.Controllers
{
    public class TodoController : Controller
    {
        // Actions go here
        public IActionResult index()
        {
            // get items from a database

            // Put items into a model

            // Render view using a model

            return View();
        }
    }    
}