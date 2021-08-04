using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
<<<<<<< HEAD
=======

>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
        private EventDbContext context;

        public EventsController(EventDbContext dbContext)
        {
            context = dbContext;
        }

<<<<<<< HEAD

        // GET: /<controller>/
        public IActionResult Index()
        {
            //List<Event> events = new List<Event>(EventData.GetAll());
=======
        // GET: /<controller>/
        public IActionResult Index()
        {
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
            List<Event> events = context.Events
                .Include(e => e.Category)
                .ToList();

            return View(events);
        }

        public IActionResult Add()
        {
            List<EventCategory> categories = context.Categories.ToList();
            AddEventViewModel addEventViewModel = new AddEventViewModel(categories);

            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory theCategory = context.Categories.Find(addEventViewModel.CategoryId);
<<<<<<< HEAD

=======
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Category = theCategory
                };

<<<<<<< HEAD
                //EventData.Add(newEvent);
                context.Events.Add(newEvent);
                context.SaveChanges();

=======
                context.Events.Add(newEvent);
                context.SaveChanges();
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a

                return Redirect("/Events");
            }

            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
<<<<<<< HEAD
            //ViewBag.events = EventData.GetAll();
=======
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
            ViewBag.events = context.Events.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
<<<<<<< HEAD
                //EventData.Remove(eventId);
=======
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
                Event theEvent = context.Events.Find(eventId);
                context.Events.Remove(theEvent);
            }
            context.SaveChanges();

            context.SaveChanges();

            return Redirect("/Events");
        }
    }
}
