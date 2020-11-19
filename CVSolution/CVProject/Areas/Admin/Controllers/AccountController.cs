using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVProject.Models.DataContext;
using CVProject.Models.Entity.Membership;
using CVProject.Models.FormModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CVProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AccountController : Controller
    {
        readonly SignInManager<AppUser> signInManager;
        readonly UserManager<AppUser> userManager;

        readonly RoleManager<AppRole> roleManagar;
        readonly CVDbContext db;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<AppRole> roleManagar, CVDbContext db)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;

            this.roleManagar = roleManagar;
            this.db = db;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        async public  Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

           var user=await userManager.FindByNameAsync(model.UserName);


            if (user==null)
            {
                TempData["message"] = "Istifadeci adi ve ya sifre sehvdir";
                return View(model);
            }

            var signInResult=await signInManager.PasswordSignInAsync(user,model.Password,true,true);

            if (!signInResult.Succeeded)
            {
                TempData["message"] = "Istifadeci adi ve ya sifre sehvdir";
                return View(model);
            }

            string redirectLink = Request.Query["ReturnUrl"];
            
            if (!string.IsNullOrWhiteSpace(redirectLink))
            {
                return Redirect(redirectLink);
            }

            return RedirectToAction("Index", "DashBoard");
        }



        public async Task<IActionResult> Roles()
        {
            return View(await db.Roles.ToListAsync());
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRole(string name)
        {
            roleManagar.CreateAsync(new AppRole
            {
                Name = name
            }).Wait();


            return RedirectToAction(nameof(Roles));

        }


        public async Task<IActionResult> Users()
        {

            return View(await db.Users.ToListAsync());
        }

        public IActionResult AddUser()
        {

            ViewData["Roles"] = new SelectList(db.Roles, "Name", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(string username,string email,string role,string password)
        {
            ViewData["Roles"] = new SelectList(db.Roles, "Name", "Name");

            var user = new AppUser
            {
                UserName = username,
                Email = email
            };

            if (userManager.CreateAsync(user, password).Result.Succeeded)
            {
                userManager.AddToRoleAsync(user, role).Wait();
            }

            return RedirectToAction(nameof(Users));

        }
    }
}
