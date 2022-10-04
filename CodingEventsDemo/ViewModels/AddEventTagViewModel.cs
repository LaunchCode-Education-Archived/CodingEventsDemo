using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventTagViewModel
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public List<SelectListItem> Tags { get; set; }

        public int TagId { get; set; }

        public AddEventTagViewModel(Event theEvent, List<Tag> possibleTags)
        {
            Tags = new List<SelectListItem>();

            //how we update our tags
            foreach (var Tag in possibleTags)
            {
                Tags.Add(new SelectListItem
                {
                    Value = Tag.Id.ToString(),
                    Text = Tag.Name
                });
            }

            Event = theEvent;

        }
        public AddEventTagViewModel()
        {

        }
    }
}

