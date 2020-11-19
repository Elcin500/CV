using CVProject.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.DataContext
{
    static public class CVSeedData
    {
        static public IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CVDbContext>();

                db.Database.Migrate(); //update -database


                //InitPortfolioCategory(db);
                //InitPortfolio(db);
                //InitCV(db);
                //InitPost(db);
                //InitAppInfo(db);

            }

            return app;
        }

        private static void InitAppInfo(CVDbContext db)
        {
            if (!db.AppInfos.Any())
            {
                db.AppInfos.Add(new AppInfo { 
                Email="elcin@mail.ru",
                Address= "Bakı,Azərbaycan",
                Phone="050-000-00-00",
                FacebookLink="facebook.com",
                TwitterLink="twitter.com",
                InstagramLink="instagram.com",
                GithubLink="github.com",
                Linkedin="linkedin.com"

                });
                db.SaveChanges();
            } 
        }

        private static void InitPost(CVDbContext db)
        {
            if (!db.Posts.Any())
            {
                var post1 = (new Post
                {
                    Title= "ENJOYING THE SMALL THINGS",
                    ImagePath= "blog-img-1.jpg",
                    Author="Admin",
                    Description= "t's time to play the music. It's time to light the lights." +
                    " It's time to meet the Muppets on the Muppet Show tonight! Boy the way Glen Miller played Songs" +
                    " the hit parade. Guys like us we had it made. Those were the days. These Happy Days are yours and mine Happy Days."
                });

                var post2 = (new Post
                {
                    Title = "ENJOYING THE SMALL THINGS",
                    ImagePath = "blog-img-2.jpg",
                    Author = "Admin",

                    Description = "t's time to play the music. It's time to light the lights." +
                  " It's time to meet the Muppets on the Muppet Show tonight! Boy the way Glen Miller played Songs" +
                  " the hit parade. Guys like us we had it made. Those were the days. These Happy Days are yours and mine Happy Days."
                });
                var post3 = (new Post
                {
                    Title = "ENJOYING THE SMALL THINGS",
                    ImagePath = "blog-img-3.jpg",
                    Author = "Admin",

                    Description = "t's time to play the music. It's time to light the lights." +
                   " It's time to meet the Muppets on the Muppet Show tonight! Boy the way Glen Miller played Songs" +
                   " the hit parade. Guys like us we had it made. Those were the days. These Happy Days are yours and mine Happy Days."
                });


                db.Posts.AddRange(post1,post2,post3);
                db.SaveChanges();
            }
        }


        private static void InitPortfolioCategory(CVDbContext db)
        {
            if (!db.PortfolioCategories.Any())
            {
                db.PortfolioCategories.AddRange(
                    new PortfolioCategory
                    {
                        Name = "Brand"
                    },
                    new PortfolioCategory
                    {
                        Name = "Design"
                    },
                    new PortfolioCategory
                    {
                        Name = "Photography"
                    },
                    new PortfolioCategory
                    {
                        Name = "Visual Design"
                    }
                    );

                db.SaveChanges();
            }
        }


        private static void InitPortfolio(CVDbContext db)
        {
            if (!db.Portfolios.Any())
            {
                db.Portfolios.AddRange(new Portfolio
                {
                    ImgPath = "img-1.jpg",
                    CategoryId = 1
                },
                new Portfolio
                {
                    ImgPath = "img-2.jpg",
                    CategoryId = 1
                },
                new Portfolio
                {
                    ImgPath = "img-3.jpg",
                    CategoryId = 2
                },
                new Portfolio
                {
                    ImgPath = "img-4.jpg",
                    CategoryId = 1
                },
                new Portfolio
                {
                    ImgPath = "img-5.jpg",
                    CategoryId = 4
                },
                new Portfolio
                {
                    ImgPath = "img-6.jpg",
                    CategoryId = 2
                },
                new Portfolio
                {
                    ImgPath = "img-7.jpg",
                    CategoryId = 1
                },
                new Portfolio
                {
                    ImgPath = "img-8.jpg",
                    CategoryId = 3
                },
                new Portfolio
                {
                    ImgPath = "img-9.jpg",
                    CategoryId = 4
                }
                );

                db.SaveChanges();
                
            }
        }

        private static void InitCV(CVDbContext db)
        {
            if (!db.Persons.Any())
            {
                var person=(new Person
                {
                    FullName="Elçin Əsgərov",
                    Age=19,
                    Location="Bakı,Azərbaycan",
                    JobTitle = "Web Developer",
                    ExperienceYear = "1 İl",
                    Degree="Bakalavr",
                    CareerLevel="Orta Səviyyə",
                    Phone="055-620-99-67",
                    Fax="000-000-00-00",
                    Email="elcinha@code.edu.az",
                    Website="Demo.com",
                    Bio= "Mən Elçin Əsgərov " +
                    " Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. " +
                    "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla" +
                    " ac diam." +
                    "Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. " +
                    "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla" +
                    " ac diam." +
                    "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla" +
                    " ac diam."
                });

                person.Skills = new List<Skill>();
                person.Skills.Add(new Skill
                {
                    Name="Html/Css",
                    Category = "Hard Skill",
                    Description= "Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi.",
                    Percent =90
                });
                person.Skills.Add(new Skill
                {
                    Name = "C#",
                    Category = "Hard Skill",
                    Description = "Cras vel lorem. Etiam pellentesque aliquet tellus.",
                    Percent = 75
                });
                person.Skills.Add(new Skill
                {
                    Name = "Məntiqi-analitik düşüncə qabiliyyəti",
                    Category = "Soft Skill",
                    Description = "Cras vel lorem. Etiam pellentesque aliquet tellus.",
                    Percent = 80
                });

                person.Experiences = new List<Experience>();

                person.Experiences.Add(new Experience
                {
                    JobTitle= "HTML5 AND CSS3 DEVELOPER",
                    JobArea= "Market Şəbəkəsi",
                    Years ="2019 - 2020",
                    CompanyLogoImgPath= "company-logo-2.jpg",
                    Location="Bakı,Azərbaycan",
                    Description= "Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. " +
                    "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla"
                });
                person.Experiences.Add(new Experience
                {
                    JobTitle = "FullStack Developer",
                    JobArea = "Bank Sistemi",
                    Years = "2018 - 2019",
                    CompanyLogoImgPath = "company-logo-1.jpg",
                    Location = "Bakı,Azərbaycan",
                    Description = "Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. " +
                "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla"
                });

                person.Studies = new List<Study>();

                person.Studies.Add(new Study
                {
                    Name = "Developer",
                    StudyArea = "Bank Sistemi",
                    Years = "2019 - 2020",
                    Location = "Bakı,Azərbaycan",
                    Description = "Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. " +
                     "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla"
                });

                person.Studies.Add(new Study
                {
                    Name = "Maliyye",
                    StudyArea = "Iqtisadiyyat",
                    Years = "2017 - 2020",
                    Location = "Bakı,Azərbaycan",
                    Description = "Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. " +
                   "Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla"
                });


                db.Persons.AddRange(person);
                db.SaveChanges();
            }
        }
    }
}
