using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string JobTitle { get; set; }
        public string ExperienceYear { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Website { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Study> Studies { get; set; }

    }
}
