using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class Study
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudyArea { get; set; }
        public string Years { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string DiplomaPath { get; set; }
        [NotMapped]
        public string DiplomaPathTemp { get; set; }

    }
}
