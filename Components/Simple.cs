

using Microsoft.AspNetCore.Mvc;

namespace NetCoreComponent.Components
{

    public class Simple : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }



    }
}