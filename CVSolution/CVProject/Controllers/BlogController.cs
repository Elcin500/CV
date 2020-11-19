using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVProject.Models.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.Controllers
{
    [AllowAnonymous]

    public class BlogController : Controller
    {
        readonly CVDbContext db;
        public BlogController(CVDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = db.Posts.ToList();

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (!db.Posts.Where(p => p.Id == id).Any())
            {
                return NotFound();
            }
            
            var model = db.Posts
                .Where(p=>p.Id==id)
                .FirstOrDefault();

            return View(model);
        }

    }
}
