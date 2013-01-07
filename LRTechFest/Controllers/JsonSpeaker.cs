using System.Collections.Generic;

namespace LRTechFest.Controllers
{
    public class Speaker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ShortBio { get { return Bio.Length > 150 ? "<p>" + Bio.Substring(0, 150) + "...</p>" : "<p>" +  Bio + "</p>"; }
        }
        public string Website { get; set; }
        public string Photo { get; set; }
        public  List<Presentation> Presentations {get;set;}

        public int Id { get; set; }


        public string FullName { get { return this.FirstName + " " + this.LastName; } }
    }

    public class Presentation
    {
        public string Track { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; } 
    }
}