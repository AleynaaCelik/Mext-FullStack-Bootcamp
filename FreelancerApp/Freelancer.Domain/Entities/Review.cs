﻿using Freelancer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Domain.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
