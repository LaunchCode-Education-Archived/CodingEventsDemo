using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);
      
            return Redirect("/Events");
        }

        public IActionResult Delete()
        {
            //ViewBag.title = "Delete Events";
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }

        [HttpGet]
        [Route("Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            //controller code will go here
            Event editingEvent = EventData.GetById(eventId);
            ViewBag.eventToEdit = editingEvent;
            ViewBag.title = "Edit Event " + editingEvent.Name + "(id = " + editingEvent.Id + ")";
            return View();
        }

        [HttpPost]
        [Route("Events/Edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string desc)
        {
            //controller code will go here
            Event editingEvent = EventData.GetById(eventId);
            editingEvent.Name = name;
            editingEvent.Description = desc;
            return Redirect("/Events");
        }
    }
}
