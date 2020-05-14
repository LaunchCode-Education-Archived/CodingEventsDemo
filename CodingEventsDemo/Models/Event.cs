using System;
namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Event()
        {
        }

        public Event(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
