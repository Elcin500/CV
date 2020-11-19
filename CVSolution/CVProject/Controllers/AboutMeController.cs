using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVProject.Models.DataContext;
using CVProject.Models.Entity;
using CVProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVProject.Controllers
{
    [AllowAnonymous]
    public class AboutMeController : Controller
    {
        readonly CVDbContext db;
        public AboutMeController(CVDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = db.Persons
                .Include(p=>p.Skills)
                .FirstOrDefault();


            return View(model);
        }


        public IActionResult Contact()
        {
             
            ViewBag.AppInfo = db.AppInfos.FirstOrDefault();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact contact)
        {
            ViewBag.AppInfo = db.AppInfos.FirstOrDefault();


            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = "Sorgunuz Gonderildi";
            }

            return View();
        }
    }
}
