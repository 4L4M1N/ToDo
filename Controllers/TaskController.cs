using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.DataAccessLayer;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

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
        /* 
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
        }*/

        //localization cookies
        [HttpPost]
         public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

    }
}