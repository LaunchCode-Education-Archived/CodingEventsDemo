using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; }

        public AddEventViewModel()
        {
            EventTypes = new List<SelectListItem>();

            EventTypes.Add(new SelectListItem
            {
                Value = EventType.CONFERENCE.ToString(),
                Text = EventType.CONFERENCE.ToString()
            });

            EventTypes.Add(new SelectListItem
            {
                Value = EventType.MEETUP.ToString(),
                Text = EventType.MEETUP.ToString()
            });

            EventTypes.Add(new SelectListItem
            {
                Value = EventType.SOCIAL.ToString(),
                Text = EventType.SOCIAL.ToString()
            });

            EventTypes.Add(new SelectListItem
            {
                Value = EventType.WORKSHOP.ToString(),
                Text = EventType.WORKSHOP.ToString()
            });
        }
    }
}
