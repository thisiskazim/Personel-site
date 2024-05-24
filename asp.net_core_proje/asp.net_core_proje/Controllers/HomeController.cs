using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.Controllers
{
    [AllowAnonymous]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

   

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();   
        }
        [HttpPost]
        public IActionResult SendMessage(ContactMessage m)
        {
            MessageManager message = new MessageManager(new EfContactMessage());
            m.Date = Convert.ToDateTime(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                m.Status = true;
                message.TAdd(m);
            return RedirectToAction("index","Home"); // Varsa bir post işlem sonrasında gösterilecek view
            

            // POST dışında gelen isteklere hata mesajı
        }

    }
}
