using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEventsDemo.Controllers
{
    public class EventTagController : Controller
    {
        private EventDbContext context;

        public EventTagController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<EventTag> tags = context.Tags.ToList();
            return View(tags);
        }

        public IActionResult Add()
        {
            EventTag tag = new EventTag();
            return View(tag);
        }

        [HttpPost]
        public IActionResult Add(EventTag tag)
        {
            if (ModelState.IsValid)
            {
                context.Tags.Add(tag);
                context.SaveChanges();
                return Redirect("/EventTag/");
            }

            return View("Add", tag);
        }
    }
}
