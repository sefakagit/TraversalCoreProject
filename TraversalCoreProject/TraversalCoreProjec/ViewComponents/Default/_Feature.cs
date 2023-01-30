using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProjec.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager= new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
          //  var values = featureManager.TGetList();
          //  ViewBag.image1=featureManager.Ge
            return View();
        }
    }
}
