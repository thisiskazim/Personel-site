using asp.net_core_proje.Areas.Writer.Models;
using Business.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace asp.net_core_proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("writer/[controller]/[action]")]
    public class UserProfilController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

       public UserProfilController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
      
            UserEditProfilViewModel model = new UserEditProfilViewModel();
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
          
            model.UserName = result.UserName;
            model.Email = result.Email;
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditProfilViewModel p)
        {
      
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            result.UserName = p.UserName;
            result.Email = p.Email;
            result.PasswordHash = _userManager.PasswordHasher.HashPassword(result, p.Password);
            var commit = await _userManager.UpdateAsync(result);
            if (commit.Succeeded)
            {
                return RedirectToAction("Index","dashboard");
            }
            return View();

        }
    }
}
