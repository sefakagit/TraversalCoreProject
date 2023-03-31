
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TraversalCoreProjec.ViewComponents.Default
{
    //Viwe Component partial View'den ayıran temel farkı veri göstermek için Controllerı hiç araya katmadan onu yormadan direkt olarak Model ile iletişime geçip veriyi gösterebilmesidir.
   
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
