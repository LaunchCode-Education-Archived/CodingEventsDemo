using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {

        static private List<Event> Events = new List<Event>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(string name, string desc)
        {
            Events.Add(new Event(name, desc));
            

            return Redirect("/Events");
        }
    }
}
