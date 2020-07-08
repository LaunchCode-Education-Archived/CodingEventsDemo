using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using CodingEventsDemo.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<EventCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();
            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory newCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();

                return Redirect("/EventCategory");
            }

            return View("Create", addEventCategoryViewModel);
        }
    }
}
