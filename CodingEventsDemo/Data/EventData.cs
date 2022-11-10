//using System;
//using System.Collections.Generic;
//using System.Linq;
//using CodingEventsDemo.Models;

//namespace CodingEventsDemo.Data
//{
//    public class EventData
//    {
//        //Events => Event
//        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

//        // GetAll
//        public static IEnumerable<Event> GetAll()
//        {
//            return Events.Values;
//        }

//        // Add
//        public static void Add(Event newEvent)
//        {
//            Events.Add(newEvent.ID, newEvent);
//            Console.WriteLine(newEvent.ID);
//        }

//        // Remove
//        public static void Remove(int id)
//        {
//            Events.Remove(id);
//        }

//        // GetById
//        public static Event GetById(int id)
//        {
//            return Events[id];
//        }
//    }
//}


// ---- no longer needed once we get to 17.3