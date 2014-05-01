using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace LRTechFest.Controllers
{
    public class SpeakersController : Controller
    {
        //
        // GET: /Speakers/

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult Call()
        {
            return View();
        }

        public ActionResult List()
        {
            string speakerfile = System.IO.File.ReadAllText(Server.MapPath("~/speakers.json"));
            var speakerObjects = JsonConvert.DeserializeObject<List<Speaker>>(speakerfile);



            return View(speakerObjects);
        }

        public ActionResult Detail(int id)
        {
            string speakerfile = System.IO.File.ReadAllText(Server.MapPath("~/speakers.json"));
            var speakerObjects = JsonConvert.DeserializeObject<List<Speaker>>(speakerfile);


            return View(speakerObjects.FirstOrDefault(x => x.Id == id));

        }
    }
}