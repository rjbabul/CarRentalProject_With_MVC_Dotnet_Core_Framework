 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Models;

namespace CarRentalSystem.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarCreate> cars { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(local); Database=CarRentalSystem; Trusted_Connection=true;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
