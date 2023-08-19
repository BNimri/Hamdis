namespace Hamdi.Models
{
    using Microsoft.EntityFrameworkCore;
    using System;

    public class HamdiDbContext : DbContext
    {
        public DbSet<personModel> People { get; set; }

        public HamdiDbContext(DbContextOptions<HamdiDbContext> options)
            : base(options)
        {

        }
    }
}
