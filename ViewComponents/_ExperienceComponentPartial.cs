using Microsoft.AspNetCore.Mvc;
using Portfolio.Dal.Context;

namespace Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
