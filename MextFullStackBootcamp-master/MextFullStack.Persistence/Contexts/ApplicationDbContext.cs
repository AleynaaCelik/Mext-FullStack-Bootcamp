using MextFullStack.Domain.Entities;
using MextFullStack.Persistence.Services;
using Microsoft.EntityFrameworkCore;

namespace MextFullStack.Persistence.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        private readonly IRoothPathService _roothPathService;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,IRoothPathService roothPathService):base(options)
        {
            _roothPathService = roothPathService;
            var rootPath=_roothPathService.GetRoothPath();
            _roothPathService.WriteTotalCount();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase("MextFullStackDB");

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
