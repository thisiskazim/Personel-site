using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ContactController:Controller
    {
        ContactManager contact = new ContactManager(new EfContact());
        MessageManager messageManager = new MessageManager(new EfContactMessage());

        //mesajlar kısmı
        public IActionResult Messages()
        {
            var val = messageManager.TGetAll();
            return View(val);
        }
        
        public IActionResult Delete(int id)
        {
            var val = messageManager.TGetById(id);
            messageManager.TDelete(val);
            return RedirectToAction("Messages");
        }
     
        public IActionResult Details(int id)
        {
            var val = messageManager.TGetById(id);
          
            return View(val);
        }

        //[HttpPost]
        //public IActionResult Details(ContactMessage mm)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        messageManager.TUpdate(mm);
        //        return RedirectToAction("Messages");
        //    }

         
        //    return View(mm);
        //}




        //iletişim yazısı kısmı
        public IActionResult GetList()
        {
          var val=  contact.TGetAll();
            return View(val);
        }
        [HttpGet]
        public IActionResult Update(int ıd)
        {
            var result = contact.TGetById(ıd);
        
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(Contact c)
        {
            if (!ModelState.IsValid)
            {
                return View(c); 
            }
            contact.TUpdate(c);


            return RedirectToAction("GetList");
        }
    }


}
