using CarParkProject.Domain.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkProject.Data.Configurations
{
    class VehicleFuelTypeConfiguration : IEntityTypeConfiguration<VehicleFuelType>
    {
        public void Configure(EntityTypeBuilder<VehicleFuelType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(20);
                        
            builder.ToTable("VehicleFuelTypes");
        }
    }
}
