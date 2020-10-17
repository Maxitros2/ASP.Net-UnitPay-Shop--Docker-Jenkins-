using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmgShop.Models
{
    public class DonatorContext : DbContext
    {
        public DonatorContext(DbContextOptions<DonatorContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Donator> Donators { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=omgsite;user=admin;password=2621823qQ");
        }
    }
}
