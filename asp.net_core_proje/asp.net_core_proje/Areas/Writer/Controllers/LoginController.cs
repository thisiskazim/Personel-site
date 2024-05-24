using asp.net_core_proje.Areas.Writer.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace asp.net_core_proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("writer/[controller]/[action]")]
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly SignInManager<WriterUser> _signManager;

        public LoginController(SignInManager<WriterUser> signManager)
        {
             _signManager = signManager;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {

            if (ModelState.IsValid)
            {
                var result = await _signManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {

                    return RedirectToAction("index", "Dashboard");


                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }



            return RedirectToAction("index", "Login");
        }

        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("index", "Login");
        }
    }
}
