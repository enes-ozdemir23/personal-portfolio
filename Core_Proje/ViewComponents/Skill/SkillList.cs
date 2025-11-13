using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal()); //araba motoru kullanıyor şeklinde düşünebilirsin.
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetList();
            return View(values);

        }

    

    }
}
