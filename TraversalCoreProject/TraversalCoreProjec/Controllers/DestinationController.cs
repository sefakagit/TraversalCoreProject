using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProjec.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetailes(int id)
        {
            ViewBag.i = id;
            var values = destinationManager.TGetByID(id);
            return View(values);  
        }
        [HttpPost]
        public IActionResult DestinationDetailes(Destination p)
        {
            return View();
        }
    }
}
