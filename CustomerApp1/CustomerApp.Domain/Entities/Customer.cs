using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
    }
}
