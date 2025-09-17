using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ITIEF.Data
{
    internal class AppDbContext : DbContext
    {
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var Connection = new ConfigurationBuilder()
            .AddJsonFile("Data/Config.json")
            .Build();
            var constr = Connection.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airline_Phone> Airline_Phones { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Emp_Qualification> Emp_Qualifications { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Aircraft_Route> Aircraft_Routes { get; set; }
    }
    }

