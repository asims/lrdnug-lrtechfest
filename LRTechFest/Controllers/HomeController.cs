using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;

namespace LRTechFest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // get total attending
            // https://www.eventbrite.com/xml/event_get?app_key=U7UL7NQU43WMCHITWL&id=4169591360


            var json = new WebClient().DownloadString("https://www.eventbrite.com/json/event_get?app_key=U7UL7NQU43WMCHITWL&id=4169591360");
            var jsonObject = JObject.Parse(json);

            // expando style instance you can just 'use' properties
            dynamic eb = jsonObject["event"];

            ViewBag.NumberRegistered = eb.num_attendee_rows ?? "0";

            
            return View();
        }

        //public ActionResult About()
        //{
        //    return View();
        //}
    }
}
