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

            foreach (var tag in possibleTags)
            {
                Tags.Add(new SelectListItem {
                    Value = tag.Id.ToString(),
                    Text = tag.Name
                });
            }

            Event = theEvent;
        }

        public AddEventTagViewModel()
        {
        }
    }
}
