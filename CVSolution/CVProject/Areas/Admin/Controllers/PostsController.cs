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
    public class PostsController : Controller
    {
        private readonly CVDbContext _context;

        public PostsController(CVDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Posts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posts.ToListAsync());
        }

        // GET: Admin/Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Posts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,ImagePath,Description,CreatedDate")] Post post, IFormFile blogImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(blogImage.FileName);
                string purePath = $"blog-{Guid.NewGuid()}{ext}";

                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);

                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    blogImage.CopyTo(fs);
                }


                post.ImagePath = purePath;


                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Admin/Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,ImagePath,Description,CreatedDate")] Post post, IFormFile blogImage)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string path = _context.Posts.AsNoTracking().FirstOrDefault(p => p.Id == id)?.ImagePath;
                    if (blogImage != null)
                    {

                        var ext = Path.GetExtension(blogImage.FileName);
                        string purePath = $"blog-{Guid.NewGuid()}{ext}";

                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", purePath);

                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            blogImage.CopyTo(fs);
                        }

                        post.ImagePath = purePath;
                    }
                    else if (post.ImagePathTemp != null)
                    {
                        post.ImagePath = post.ImagePathTemp;
                    }
                    

                    _context.Update(post);
                    await _context.SaveChangesAsync();



                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(post.ImagePathTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
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
            return View(post);
        }

        // GET: Admin/Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(p=>p.Id==id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            string file = post.ImagePath;      

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", file));
            

            return Json(new
            {
                error = false,
                message = "ok"
            });

        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
