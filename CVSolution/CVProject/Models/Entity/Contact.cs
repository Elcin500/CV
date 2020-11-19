using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required(ErrorMessage = "Email Doldurulmalidir")]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
