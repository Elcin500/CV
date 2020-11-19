using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public int CategoryId { get; set; }
        public virtual PortfolioCategory Category { get; set; }

    }
}
