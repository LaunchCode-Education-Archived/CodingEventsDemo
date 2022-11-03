using System;
using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasKey(e => new {e.Id });
        }


    }
}

