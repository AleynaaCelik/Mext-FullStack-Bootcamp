using GptExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GptExample.Persistance.Context
{
    public class GPTExampleDBContext:DbContext
    {
        public DbSet<GptPrompt> prompts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=GptExampleDb;User Id=postgres;Password=mysecretpassword;");
        }
    }
}
