using asp.net_core_proje.Areas.Writer.Models;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.Areas.Writer.Controllers
{
	[Area("Writer")]
    [Route("writer/Message")]
    public class MessageController : Controller
	{
		WriterMessageManager writermesag = new WriterMessageManager(new EfWriterMessage());
		private readonly UserManager<WriterUser> _userManager;

		public MessageController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

        [Route("")]
        [Route("ReceiverMessage")]
		public async Task<IActionResult> ReceiverMessage(string p)
		{
			var loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
			p = loginUser.Email;
			var result = writermesag.TGetReceiverFilter(p);

			return View(result);
		}
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(string p)
        {
            var loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
            p = loginUser.Email;
            var result = writermesag.TGetSendFilter(p);

            return View(result);
        }
        [Route("DetailsSendMessage/{id}")]
        public IActionResult DetailsSendMessage(int id)
        {

			var result = writermesag.TGetById(id);

            return View(result);
        }
        [Route("DetailsReceiverMessage/{id}")]
        public IActionResult DetailsReceiverMessage(int id)
        {
            var result = writermesag.TGetById(id);

            return View(result);
        }

        [HttpGet]
        [Route("")]
        [Route("NewMessage")]
        public async Task<IActionResult> NewMessage()
        {
            WriterMessage w = new WriterMessage();
            var sendersUser = await _userManager.FindByNameAsync(User.Identity.Name);
            w.Sender = sendersUser.Email;
            w.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            return View(w);
        }
        [HttpPost]
        [Route("")]
        [Route("NewMessage")]
        public  IActionResult NewMessage(WriterMessage p)
        {
            if (ModelState.IsValid)
            {
                writermesag.TAdd(p);
                return RedirectToAction("sendmessage", "Message");
            }


            return View();
        }

    }
}
