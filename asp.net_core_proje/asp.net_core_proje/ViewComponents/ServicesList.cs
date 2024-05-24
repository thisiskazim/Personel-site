using Business.Concrete;

using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class ServicesList : ViewComponent
    {
        ServiceManager service = new ServiceManager(new EfServices());
        public IViewComponentResult Invoke()
        {
            var values = service.TGetAll();
            return View(values);
        }
    }
}
