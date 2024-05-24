using Business.Concrete;

using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experience = new ExperienceManager(new EfExperience());
        public IViewComponentResult Invoke()
        {
            var values = experience.TGetAll();
            return View(values);
        }
    }
}
