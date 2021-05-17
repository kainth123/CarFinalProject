using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarFinalProject.Models;

namespace CarFinalProject.Data
{
    public class CarFinalProjectContext : DbContext
    {
        public CarFinalProjectContext (DbContextOptions<CarFinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CarFinalProject.Models.Car> Car { get; set; }

        public DbSet<CarFinalProject.Models.Staff> Staff { get; set; }

        public DbSet<CarFinalProject.Models.Customer> Customer { get; set; }
    }
}
