using Business.Concrete;

using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager port = new PortfolioManager(new EfPortfolio());
        public IViewComponentResult Invoke()
        {
            var values = port.TGetAll();
            return View(values);
        }
    }
}
