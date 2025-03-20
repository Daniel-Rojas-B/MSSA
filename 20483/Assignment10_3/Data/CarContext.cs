using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment10_3.Models;

namespace Assignment10_3.Data
{
    public class CarContext : DbContext // represent the database base in my server
    {
        public DbSet<Car> Cars { get; set; } // table 
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DR;initial catalog=PCAD16Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Vin = "1HGCM82633A123456", Make = "BMW", Model = "M4", Year = 2021, Price = 65000 }                
                );
            
        }
    }
}
