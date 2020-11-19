using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CVProject.Models.DataContext;
using CVProject.Models.Entity;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace CVProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudiesController : Controller
    {
        private readonly CVDbContext _context;

        public StudiesController(CVDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Studies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Studies.ToListAsync());
        }

        // GET: Admin/Studies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Studies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }

            return View(study);
        }

        // GET: Admin/Studies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Studies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StudyArea,Years,Location,Description,DiplomaPath")] Study study, IFormFile diploma)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(diploma.FileName);
                string purePath = $"study-{Guid.NewGuid()}{ext}";

                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);

                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    diploma.CopyTo(fs);
                }

                study.DiplomaPath = purePath;

                var person = _context.Persons.Include(p => p.Studies).FirstOrDefault();

                person.Studies.Add(study);

                _context.Update(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(study);
        }

        // GET: Admin/Studies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Studies.FindAsync(id);
            if (study == null)
            {
                return NotFound();
            }
            return View(study);
        }

        // POST: Admin/Studies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StudyArea,Years,Location,Description,DiplomaPath")] Study study, IFormFile diploma)
        {
            if (id != study.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string path = _context.Studies.AsNoTracking().FirstOrDefault(p => p.Id == id)?.DiplomaPath;
                    if (diploma != null)
                    {

                        var ext = Path.GetExtension(diploma.FileName);
                        string purePath = $"study-{Guid.NewGuid()}{ext}";

                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", purePath);

                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            diploma.CopyTo(fs);
                        }

                        study.DiplomaPath = purePath;
                    }
                    else if (study.DiplomaPathTemp != null)
                    {
                        study.DiplomaPath = study.DiplomaPathTemp;
                    }



                    _context.Update(study);
                    await _context.SaveChangesAsync();


                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(study.DiplomaPathTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudyExists(study.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(study);
        }

        // GET: Admin/Studies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Studies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }

            return View(study);
        }

        // POST: Admin/Studies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var study = await _context.Studies.FindAsync(id);

            string file = study.DiplomaPath;

            _context.Studies.Remove(study);
            await _context.SaveChangesAsync();

            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", file));


            return Json(new
            {
                error = false,
                message = "ok"
            });

        }

        private bool StudyExists(int id)
        {
            return _context.Studies.Any(e => e.Id == id);
        }
    }
}
