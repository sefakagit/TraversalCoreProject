using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProjec.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {

        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values=testimonialManager.TGetList();
            return View(values);
        }
    }
}
