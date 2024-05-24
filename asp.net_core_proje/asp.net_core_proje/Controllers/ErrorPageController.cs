using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.Controllers
{
	public class ErrorPageController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
			public IActionResult Error404()
		{
			return View();
		}
	}
}
