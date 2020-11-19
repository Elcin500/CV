using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVProject.Models.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVProject.Controllers
{
    public class ResumeController : Controller
    {

        readonly CVDbContext db;
        public ResumeController(CVDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = db.Persons
                .Include(p=>p.Studies)
                .Include(p=>p.Experiences)
               .Include(p => p.Skills)
               .FirstOrDefault();


            return View(model);
        }
    }
}
