using EFPostgre.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPostgre.Domain.Entities
{
    public class Person:EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phonenumber { get; set; }
    }
}
