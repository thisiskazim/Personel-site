using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    [Route("writer/[controller]/[action]")]
    public class HomeController : Controller
    {

        AnnouncementManager announcement = new AnnouncementManager(new EfAnnouncement());
        public IActionResult Index()
        {
            var result = announcement.TGetAll();
            return View(result);
        }
    }
}
