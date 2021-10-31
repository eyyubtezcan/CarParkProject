using CarParkProject.Domain.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkProject.Data.Configurations
{
    class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PlateNumber).IsRequired().HasMaxLength(8);
            builder.Property(x => x.ChassisNumber).IsRequired().HasMaxLength(17);
            builder.Property(x => x.ColorId).IsRequired();
            builder.Property(x => x.FuelTypeId).IsRequired();
            builder.Property(x => x.ModelId).IsRequired();
            
            builder.ToTable("Vehicles");
        }
    }
}
