using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ContactEmail { get; set; }

<<<<<<< HEAD
        //public EventType Type { get; set; }

        public EventCategory Category { get; set; }

        public int CategoryId { get; set; }

        public int Id { get; set; }

        public Event()
        {
        }
=======
        public EventCategory Category { get; set; }

        public int CategoryId { get; set; }

        public int Id { get; set; }
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a

        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        public Event()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
