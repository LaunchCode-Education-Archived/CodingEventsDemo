using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Threading.Tasks;
=======
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
<<<<<<< HEAD
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Event> Events { get; set; }

        public EventCategory()
        {
        }

        public EventCategory(string name)
        {
            Name = Name;
=======
        public string Name { get; set; }

        public int Id { get; set; }

        public List<Event> events { get; set; }

        public EventCategory(string name)
        {
            Name = name;
        }

        public EventCategory()
        {
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
        }
    }
}
