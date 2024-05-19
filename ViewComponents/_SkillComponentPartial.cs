using Microsoft.AspNetCore.Mvc;
using Portfolio.Dal.Context;
namespace Portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolioContext context = new();
        
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
