using EventList.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventList.Domain.Entities
{
    public class Event:EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        
        public Person Owner { get; set; }

    }
}
