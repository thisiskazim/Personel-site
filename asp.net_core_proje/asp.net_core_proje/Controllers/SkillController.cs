using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class SkillController:Controller
	{
        SkillManager skill = new SkillManager(new EfSkill());
        public IActionResult GetList()
		{
		
			var values = skill.TGetAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Add(Skill s)
        {
			if (!ModelState.IsValid)
			{
                return View(s);
            }

            skill.TAdd(s);
            return RedirectToAction("GetList");	
        }
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var value = skill.TGetById(id);
			skill.TDelete(value);
			return RedirectToAction("GetList");
		}

        [HttpGet]
        public IActionResult Update(int id)
        {
			var value = skill.TGetById(id);

            return View(value);

        }

        [HttpPost]
		public IActionResult Update(Skill s) 
		{
			if (!ModelState.IsValid)
			{
				return View(s);
			}
			skill.TUpdate(s);
			return RedirectToAction("GetList");

		}


    }
}
