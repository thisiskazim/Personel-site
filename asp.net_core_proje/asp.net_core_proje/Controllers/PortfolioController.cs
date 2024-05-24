using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class PortfolioController: Controller
    {
        PortfolioManager portfolio = new PortfolioManager(new EfPortfolio());
        public IActionResult GetList()
        {

            var values = portfolio.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Portfolio s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }

            portfolio.TAdd(s);
            return RedirectToAction("GetList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = portfolio.TGetById(id);
            portfolio.TDelete(value);
            return RedirectToAction("GetList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = portfolio.TGetById(id);

            return View(value);

        }

        [HttpPost]
        public IActionResult Update(Portfolio s)
        {
            if (!ModelState.IsValid)
            {
                return View(s);
            }
            portfolio.TUpdate(s);
            return RedirectToAction("GetList");

        }

    }
}
