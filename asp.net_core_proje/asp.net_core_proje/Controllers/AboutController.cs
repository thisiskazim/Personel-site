using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AboutController:Controller
    {
        AboutManager about = new AboutManager(new EfAbout());
    
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = about.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(About a)
        {
            if (ModelState.IsValid)
            {
                about.TUpdate(a);
                return RedirectToAction("Dashboard");
            }
            return View(a);
           
        }
    }
}
