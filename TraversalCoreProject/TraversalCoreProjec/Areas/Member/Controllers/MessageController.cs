using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProjec.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
