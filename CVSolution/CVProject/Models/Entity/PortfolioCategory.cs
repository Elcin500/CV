using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.Entity
{
    public class PortfolioCategory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Portfolio> Portfolios { get; set; }
    }
}
