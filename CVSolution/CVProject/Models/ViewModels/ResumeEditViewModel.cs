using CVProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.ViewModels
{
    public class ResumeEditViewModel
    {
        public Person Person { get; set; }
        public AppInfo AppInfo { get; set; }
        public Skill Skill { get; set; }
        public Experience Experience { get; set; }
        public Study Study { get; set; }
    }
}
