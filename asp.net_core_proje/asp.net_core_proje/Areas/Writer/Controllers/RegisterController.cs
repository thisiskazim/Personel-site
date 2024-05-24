using asp.net_core_proje.Areas.Writer.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace asp.net_core_proje.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Route("writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                WriterUser write = new WriterUser()
                {   
                    UserName = model.UserName,

                    Email = model.Email,
              
                };

                if (model.Password == model.ConfirmPassword)
                {
                  var result =await _userManager.CreateAsync(write,model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");

                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                }

            }
            return View(model);
        }
    }
}
