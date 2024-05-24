using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	
	[Authorize(Roles = "Admin")]
	
	public class FeatureController:Controller
    {

        FeatureManager feature = new FeatureManager(new EfFeature());
   
        public IActionResult GetList()
		{

			var values = feature.TGetAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult Update(int id)
		{
			var value = feature.TGetById(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult Update(Feature f)
		{
			feature.TUpdate(f);
			return RedirectToAction("GetList");
		}
	}
}
