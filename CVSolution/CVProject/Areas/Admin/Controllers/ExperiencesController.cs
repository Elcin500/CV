using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CVProject.Models.DataContext;
using CVProject.Models.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CVProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperiencesController : Controller
    {
        private readonly CVDbContext _context;

        public ExperiencesController(CVDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Experiences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Experiences.ToListAsync());
        }

        // GET: Admin/Experiences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // GET: Admin/Experiences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Experiences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Years,CompanyLogoImgPath,JobTitle,JobArea,Location,Description")] Experience experience, IFormFile experienceImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(experienceImage.FileName);
                string purePath = $"experience-{Guid.NewGuid()}{ext}";

                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);

                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    experienceImage.CopyTo(fs);
                }


                experience.CompanyLogoImgPath = purePath;


                var person = _context.Persons.Include(p => p.Experiences).FirstOrDefault();

                person.Experiences.Add(experience);

                _context.Update(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(experience);
        }

        // GET: Admin/Experiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences.FindAsync(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }

        // POST: Admin/Experiences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Years,CompanyLogoImgPath,JobTitle,JobArea,Location,Description")] Experience experience, IFormFile experienceImage)
        {
            if (id != experience.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string path = _context.Posts.AsNoTracking().FirstOrDefault(p => p.Id == id)?.ImagePath;
                    if (experienceImage != null)
                    {

                        var ext = Path.GetExtension(experienceImage.FileName);
                        string purePath = $"experience-{Guid.NewGuid()}{ext}";

                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", purePath);

                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            experienceImage.CopyTo(fs);
                        }

                        experience.CompanyLogoImgPath = purePath;
                    }
                    else if (experience.CompanyLogoImgPathTemp != null)
                    {
                        experience.CompanyLogoImgPath = experience.CompanyLogoImgPathTemp;
                    }


                    _context.Update(experience);
                    await _context.SaveChangesAsync();


                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(experience.CompanyLogoImgPathTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExperienceExists(experience.Id))
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
            return View(experience);
        }

        // GET: Admin/Experiences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experience = await _context.Experiences
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // POST: Admin/Experiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var experience = await _context.Experiences.FindAsync(id);

            string file = experience.CompanyLogoImgPath;


            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();

            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", file));


            return Json(new
            {
                error = false,
                message = "ok"
            });

        }

        private bool ExperienceExists(int id)
        {
            return _context.Experiences.Any(e => e.Id == id);
        }
    }
}
