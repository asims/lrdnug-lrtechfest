using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LRTechFest.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return Redirect("http://lrtechfest.eventbrite.com/?ref=lrtechfest.com");
        }

    }
}
