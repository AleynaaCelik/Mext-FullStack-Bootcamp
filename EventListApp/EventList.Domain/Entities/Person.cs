﻿using EventList.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventList.Domain.Entities
{
    public class Person:EntityBase
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
