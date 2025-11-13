using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        
        public IViewComponentResult Invoke()
        {
            var values=featureManager.TGetList();
            return View(values);
        }
    }
}


//  Invoke metoduna bağlı olarak çalışacak view'leri Shared-Components içinde bulup getirecek.
//  Başka bir klasörde tanımlayıpta yolunu verebiliriz.
//  Class'ın adı Components içindeki klasörle aynı olmalıdır.
//  Yani klasörde FeatureList adında bir klasörde olmalıdır.
//  FeatureList'in içine ise bir partialView ekleyeceğiz
//  PartialView'i Default olarak adlandıracağız(kural)
