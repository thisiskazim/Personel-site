using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ServiceController: Controller
    {
        ServiceManager service = new ServiceManager(new EfServices());
        public ActionResult GetList()
        {
           var value = service.TGetAll();
            return View(value);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Services s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }

            service.TAdd(s);
            return RedirectToAction("GetList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = service.TGetById(id);
            service.TDelete(value);
            return RedirectToAction("GetList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = service.TGetById(id);

            return View(value);

        }

        [HttpPost]
        public IActionResult Update(Services s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }
            service.TUpdate(s);
            return RedirectToAction("GetList");

        }

    }
}
