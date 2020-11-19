using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class AppInfo
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string GithubLink { get; set; }
        public string Linkedin { get; set; }

    }
}
