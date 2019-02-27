using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.DataAccessLayer;

namespace ToDo.Controllers
{
    public class TaskController : Controller
    {
        
        private readonly TodoDbContext _db;
        public TaskController(TodoDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create( Work addWork)
        {
            if(ModelState.IsValid)
            {
                addWork.Status = false;
                _db.Add(addWork);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}