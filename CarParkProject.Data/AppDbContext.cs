using CarParkProject.Data.Configurations;
using CarParkProject.Data.Seeds;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Text;


namespace CarParkProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base
            (options)
        {

        }
        //Settings
        public DbSet<Config> Config { get; set; }
        
        //Customer
        public DbSet<Customer> Customers { get; set; }
        public DbQuery<CustomerVM> CustomerView { get; set; }
        //Vehicle
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<VehicleColor> VehicleColors { get; set; }
        public DbSet<VehicleFuelType> VehicleFuelTypes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        //Manage
        public DbSet<Ticket> Tickets{ get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }

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
