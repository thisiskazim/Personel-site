using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessage = new WriterMessageManager(new EfWriterMessage());

        public IActionResult SenderMessage()
        {
            string p = "admin@gmail.com";
            var c = writerMessage.TGetSendFilter(p);
            return View(c);
        }
        public IActionResult ReceiverMessage()
        {
            string p = "admin@gmail.com";
            var c = writerMessage.TGetReceiverFilter(p);
            return View(c);
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            WriterMessage p =new WriterMessage();
            p.Sender = "admin@gmail.com";
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            return View(p);
        }
        [HttpPost]
        public IActionResult AddSendMessage(WriterMessage p)
        {
            if (ModelState.IsValid)
            {
                writerMessage.TAdd(p);

                return RedirectToAction("SenderMessage");
            }
           

            return View(p);
        }

        public IActionResult DetailsReceiver(int id)
        {
            var val = writerMessage.TGetById(id);

            return View(val);
        }
        public IActionResult DetailsSend(int id)
        {
            var val = writerMessage.TGetById(id);

            return View(val);
        }
      
        public IActionResult Delete(int id ,string returnUrl)
        {
            var val = writerMessage.TGetById(id);
            writerMessage.TDelete(val);
            return Redirect(returnUrl);
        }

    }
}
