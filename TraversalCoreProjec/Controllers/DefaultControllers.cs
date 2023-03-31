using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProjec.Controllers
{
    public class DefaultControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
