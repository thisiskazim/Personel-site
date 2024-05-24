using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AdminController:Controller
    {
    


        public IActionResult Dashboard()
        {
            return View();
        }


    
    }
}
