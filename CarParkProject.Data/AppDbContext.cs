using CarParkProject.Data.Configurations;
using CarParkProject.Data.Seeds;
using CarParkProject.Domain.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base
            (options)
        {

        }
        public DbSet<Config> Config { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<VehicleColor> VehicleColors { get; set; }
        public DbSet<VehicleFuelType> VehicleFuelTypes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

       
        public DbSet<Ticket> Tickets{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleBrandConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleColorConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleFuelTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleModelConfiguration());


            modelBuilder.ApplyConfiguration(new ConfigSeed(new int[] { 1, 2, 3 }));


            //modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2, 3, 4 }));
            //modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2, 3, 4 }));

        }

    }
}
