using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CVProject.Models.DataContext;
using CVProject.Models.Entity;
using CVProject.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CVProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppInfoAndPersonController : Controller
    {
        private readonly CVDbContext db;

        public AppInfoAndPersonController(CVDbContext context)
        {
           db= context;
        }
        public IActionResult Index()
        {
            string[] values = { "FullName", "Age", "Location", "ExperienceYear", "Degree", "CareerLevel", "Phone", "Fax", "Email", "Website" };

            ViewData["AppInfos"] = new SelectList(values);

            var model = new ResumeEditViewModel();

            model.AppInfo= db.AppInfos.FirstOrDefault();

            model.Person = db.Persons.FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> ProfessionalDetails(string text,string title)
        {

            var person= db.Persons.FirstOrDefault();

            switch (title)
            {
                case "FullName":
                    person.FullName = text;
                    break;
                case "Age":
                    person.Age = Convert.ToInt32(title);
                    break;
                case "ExperienceYear":
                    person.ExperienceYear = text;
                    break;
                case "Degree":
                    person.Degree = text;
                    break;
                case "CareerLevel":
                    person.CareerLevel = text;
                    break;
                case "Phone":
                    person.Phone = text;
                    break;
                case "Fax":
                    person.Fax = text;
                    break;
                case "Email":
                    person.Email = text;
                    break;
                case "Website":
                    person.Website = text;
                    break;

                default:
                    break;
            }

            db.Update(person);
            await db.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> SocialLinks(string facebookLink,string twitterLink, string instagramLink,string linkedin,string githubLink)
        {
            var appInfo = db.AppInfos.FirstOrDefault();

            appInfo.FacebookLink = facebookLink;
            appInfo.TwitterLink = twitterLink;
            appInfo.InstagramLink = instagramLink;
            appInfo.Linkedin = linkedin;
            appInfo.GithubLink = githubLink;


            db.Update(appInfo);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> PersonBio(string bio)
        {
            var person = db.Persons.FirstOrDefault();

            person.Bio = bio;

            db.Update(person);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> SkillAdd(string category, string name,string percent,string description)
        {
            var person = db.Persons.Include(p=>p.Skills).FirstOrDefault();

            var skill = new Skill();

            skill.Category = category;
            skill.Name = name;
            skill.Percent = Convert.ToInt32(percent);
            skill.Description = description;

            person.Skills.Add(skill);

            db.Update(person);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> ExperienceAdd(string years, string jobTitle, string jobArea, string location, IFormFile logo,string description)
        {
            var person = db.Persons.Include(p => p.Experiences).FirstOrDefault();

            var experience = new Experience();

            experience.Years = years;
            experience.JobTitle = jobTitle;
            experience.JobArea = jobArea;
            experience.Location = location;
            experience.Description = description;

            var ext = Path.GetExtension(logo.FileName);
            string purePath = $"experience-{Guid.NewGuid()}{ext}";

            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);

            using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
            {
                logo.CopyTo(fs);
            }


            experience.CompanyLogoImgPath = purePath;


            person.Experiences.Add(experience);

            db.Update(person);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> StudyAdd( string name, string studyArea, string years,  string location, IFormFile diploma, string description)
        {
            var person = db.Persons.Include(p => p.Studies).FirstOrDefault();

            var study = new Study();

            study.Name = name;
            study.StudyArea = studyArea;
            study.Years = years;
            study.Location = location;
            study.Description = description;


            var ext = Path.GetExtension(diploma.FileName);
            string purePath = $"study-{Guid.NewGuid()}{ext}";

            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);

            using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
            {
                diploma.CopyTo(fs);
            }

            study.DiplomaPath = purePath;


            person.Studies.Add(study);

            db.Update(person);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }

}
