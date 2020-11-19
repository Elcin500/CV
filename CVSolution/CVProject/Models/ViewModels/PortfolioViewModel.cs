using CVProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.ViewModels
{
    public class PortfolioViewModel
    {
        public List<PortfolioCategory> PortfolioCategories { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
