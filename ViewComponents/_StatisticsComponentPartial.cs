using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _StatisticsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
