using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVProject.Models.DataContext;
using CVProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVProject.Controllers
{
    [AllowAnonymous]
    public class PortfolioController : Controller
    {
        readonly CVDbContext db;
        public PortfolioController(CVDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = new PortfolioViewModel();
            model.Portfolios = db.Portfolios
                .Include(p=>p.Category)
                .ToList();

            model.PortfolioCategories = db.PortfolioCategories
                .Include(p=>p.Portfolios)
                .ToList();

            return View(model);
        }
    }
}
