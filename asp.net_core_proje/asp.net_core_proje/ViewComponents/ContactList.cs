using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class ContactList : ViewComponent
    {
        ContactManager contact = new ContactManager(new EfContact());
        public IViewComponentResult Invoke()
        {
            var values = contact.TContactwithAbout();
            return View(values);
        }
    }
}
