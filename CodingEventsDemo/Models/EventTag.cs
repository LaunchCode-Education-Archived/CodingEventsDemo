using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.Models
{
    public class EventTag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        public EventTag(string name)
        {
            Name = name;
        }

        public EventTag()
        {
        }
    }
}
