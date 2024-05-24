using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class FeatureList : ViewComponent
    {
        FeatureManager feature = new FeatureManager(new EfFeature());
        public IViewComponentResult Invoke()
        {
           var values= feature.TGetAll();
            return View(values);
        }
    }
}
