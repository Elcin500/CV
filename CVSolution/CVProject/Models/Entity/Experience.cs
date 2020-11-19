using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class Experience
    {
        public int Id { get; set; }
        public string Years { get; set; }
        public string CompanyLogoImgPath { get; set; }
        [NotMapped]
        public string CompanyLogoImgPathTemp { get; set; }

        public string JobTitle { get; set; }
        public string JobArea { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
