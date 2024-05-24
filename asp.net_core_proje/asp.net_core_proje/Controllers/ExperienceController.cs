using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperienceController:Controller
    {

        ExperienceManager experience = new ExperienceManager(new EfExperience());
        public IActionResult GetList()
        {

            var values = experience.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Experience s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }

            experience.TAdd(s);
            return RedirectToAction("GetList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = experience.TGetById(id);
            experience.TDelete(value);
            return RedirectToAction("GetList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = experience.TGetById(id);

            return View(value);

        }

        [HttpPost]
        public IActionResult Update(Experience s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }
            experience.TUpdate(s);
            return RedirectToAction("GetList");

        }


    }
}
