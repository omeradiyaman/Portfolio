using Microsoft.AspNetCore.Mvc;
using Portfolio.Dal.Context;

namespace Portfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
