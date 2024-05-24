using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class SocialMediaController: Controller
    {
        SocialMediaManager manager = new SocialMediaManager(new EfSocialMedia());


        public IActionResult GetList()
        {
           
            var values = manager.TGetAll();
            return View(values);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SocialMedia s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }

            manager.TAdd(s);
            return RedirectToAction("GetList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = manager.TGetById(id);
            manager.TDelete(value);
            return RedirectToAction("GetList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = manager.TGetById(id);

            return View(value);

        }

        [HttpPost]
        public IActionResult Update(SocialMedia s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }
            manager.TUpdate(s);
            return RedirectToAction("GetList");

        }






    }
}
