using EventList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventList.Domain.Dtos
{
    public class AddEventDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public Guid PersonId { get; set; }
        
        
    }
}
