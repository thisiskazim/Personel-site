using Business.Concrete;

using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ProjectList: ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolio());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetAll();
            return View(values);
        }
    }
}
