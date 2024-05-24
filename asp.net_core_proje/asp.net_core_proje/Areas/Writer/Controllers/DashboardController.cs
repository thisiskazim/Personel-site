using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace asp.net_core_proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("writer/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Context c = new Context();
            string api = "0584787a571c8013e09e0d428a75d47d";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=konya&mode=xml&lang=tr&units=metric&appid="+api;
			try
			{
				XDocument xDocument = XDocument.Load(connection);
				ViewBag.v6 = xDocument.Descendants("temperature").FirstOrDefault()?.Attribute("value")?.Value;
				ViewBag.v7 = xDocument.Descendants("city").FirstOrDefault()?.Attribute("name")?.Value;

			}
			catch (Exception ex)
			{
				// Hata işleme kodu
				ViewBag.v6 = "Hata oluştu: " + ex.Message;
			
			}

			ViewBag.v1 = user.UserName;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 =c.Users.Count();
            ViewBag.v4 = c.WriterMessages.Where(x => x.Receiver == user.Email).Count();
            ViewBag.v5 = c.WriterMessages.Where(x => x.Sender == user.Email).Count(); ;
        
            return View();
        }
    }
}
