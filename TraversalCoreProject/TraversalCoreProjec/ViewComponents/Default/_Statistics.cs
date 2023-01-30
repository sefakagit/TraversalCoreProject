using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProjec.ViewComponents.Default
{
    public class _Statistics: ViewComponent
    {
   
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();

            ViewBag.v3 = "1461";
            return View();
        }
    }
}
