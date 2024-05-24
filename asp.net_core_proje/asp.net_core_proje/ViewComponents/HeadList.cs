using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class HeadList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
