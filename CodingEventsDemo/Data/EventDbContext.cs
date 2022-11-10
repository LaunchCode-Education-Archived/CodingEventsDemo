using System;
using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
//using static Google.Protobuf.Collections.MapField<TKey, TValue>;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
//created in 17.2

namespace CodingEventsDemo.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options)
                   : base(options)
        {
        }
    }
}
