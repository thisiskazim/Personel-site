using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_proje.ViewComponents
{
    public class SkillList : ViewComponent
    {

        SkillManager skill = new SkillManager(new EfSkill());
        public IViewComponentResult Invoke()
        {
            var values = skill.TGetAll();
            return View(values);
        }
    }
}
