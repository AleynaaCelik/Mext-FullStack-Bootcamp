using EventList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventListApp.Persistance.Contexts
{
    public class EventListDbContext:DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Person> People{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventListApp");
        }
    }
}
