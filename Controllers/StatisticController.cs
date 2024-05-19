using Microsoft.AspNetCore.Mvc;
using Portfolio.Dal.Context;

namespace Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext context = new();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
