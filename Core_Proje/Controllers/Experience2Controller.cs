using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {


            return View();
        }
        public IActionResult ListExperience()

        {
            var values = experienceManager.TGetList();

            //var values = JsonConvert.SerializeObject(writerUserManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = p;
            return Json(values);
        }
        public IActionResult GetById(int ExperienceID)
        {
            var values=experienceManager.TGetByID(ExperienceID);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var values=experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return Json(new { result = "ok" });
        }

    }
}
