using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace NetCoreComponent.Components
{

    public class Todo : ViewComponent
    {

        public IViewComponentResult Invoke(string str)
        {
            string[] all = str.Split(new char[] { ';' });
            return View(all);
        }


    }
}
