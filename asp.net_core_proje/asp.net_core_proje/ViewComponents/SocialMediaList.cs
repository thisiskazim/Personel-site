using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager social = new SocialMediaManager(new EfSocialMedia());
        public IViewComponentResult Invoke()
        {

            var values = social.TGetAll().Where(x => x.Status == true).ToList();
            return View(values);
        }
    }
}
