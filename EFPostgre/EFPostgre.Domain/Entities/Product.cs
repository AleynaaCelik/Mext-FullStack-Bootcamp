using EFPostgre.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPostgre.Domain.Entities
{
    public class Product:EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
