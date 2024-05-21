using Freelancer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Persistance.Contexts
{
    public class FreelancerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        
    }
}
