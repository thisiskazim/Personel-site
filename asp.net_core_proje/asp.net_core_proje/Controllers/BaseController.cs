using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class BaseController<Tentity,Tmanager>:Controller 
        where Tentity : class 
        where Tmanager: IGenericService<Tentity>    
    {
        protected readonly Tmanager _manager;
        public BaseController(Tmanager manager)
        {
            _manager = manager;
        }

        public IActionResult GetList()
        {

            var values = _manager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Tentity s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }

            _manager.TAdd(s);
            return RedirectToAction("GetList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = _manager.TGetById(id);
            _manager.TDelete(value);
            return RedirectToAction("GetList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _manager.TGetById(id);

            return View(value);

        }

        [HttpPost]
        public IActionResult Update(Tentity s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }
            _manager.TUpdate(s);
            return RedirectToAction("GetList");

        }



    }
}
