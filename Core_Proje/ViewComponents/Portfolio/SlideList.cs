using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values = portfolioManager.TGetList();
            return View(values);

        }
    
    }
}
