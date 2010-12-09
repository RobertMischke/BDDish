using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDDish.View.Web
{
    [HandleError]
    public class WelcomeController : Controller
    {
        public ActionResult Welcome()
        {
            return View(new WelcomeModel { FeatureTitle = "test"});
        }

    }
}
