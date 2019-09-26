using Microsoft.EntityFrameworkCore;
using Parking.Domain.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Context
{
    public class ParkingDataContext : DbContext
    {
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Agreement> Agreement { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost,1433;Database=parking.database;User ID=sa;Password=cm@123456789;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgreementMap());
            builder.ApplyConfiguration(new CarMap());
            builder.ApplyConfiguration(new CustomerMap());
            builder.ApplyConfiguration(new ParkingMap());
            builder.ApplyConfiguration(new RateMap());
        }
    }
}
