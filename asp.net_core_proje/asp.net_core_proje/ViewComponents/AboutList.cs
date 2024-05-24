using Business.Concrete;

using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class AboutList : ViewComponent
    {
        AboutManager about = new AboutManager(new EfAbout());
        public IViewComponentResult Invoke()
        {
            var values = about.TGetById(1);
            return View(values);
        }
    }
}
