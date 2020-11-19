using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CVProject.Models.DataContext;
using CVProject.Models.Entity;

namespace CVProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillsController : Controller
    {
        private readonly CVDbContext _context;

        public SkillsController(CVDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Skills
        public async Task<IActionResult> Index()
        {
            return View(await _context.Skills.ToListAsync());
        }

        // GET: Admin/Skills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // GET: Admin/Skills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Skills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Category,Description,Percent")] Skill skill)
        {
            if (ModelState.IsValid)
            {

                var person = _context.Persons.Include(p => p.Skills).FirstOrDefault();

                person.Skills.Add(skill);

                _context.Update(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        // GET: Admin/Skills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }

        // POST: Admin/Skills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,Description,Percent")] Skill skill)
        {
            if (id != skill.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillExists(skill.Id))
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
            return View(skill);
        }

        // GET: Admin/Skills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // POST: Admin/Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();

            return Json(new
            {
                error = false,
                message = "ok"
            });
        }

        private bool SkillExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
