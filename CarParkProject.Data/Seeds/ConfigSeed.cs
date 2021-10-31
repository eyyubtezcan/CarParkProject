using CarParkProject.Domain.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data.Seeds
{
    class ConfigSeed : IEntityTypeConfiguration<Config>
    {
        private readonly int[] _ids;

        public ConfigSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Config> builder)
        {
            builder.HasData(
                new Config
                {
                    Id = 1,
                    Description = "System Status",
                    Value="1",
                    IsActive = true,
                    CreatedById = 1,
                    CreatedDate = DateTime.Now
                },
                new Config
                {
                    Id = 2,
                    Description = "Total Car Capacity",
                    Value = "200",
                    IsActive = true,
                    CreatedById = 1,
                    CreatedDate = DateTime.Now
                },
                new Config
                {
                    Id = 3,
                    Description = "Total Commuter Capacity",
                    Value = "180",
                    IsActive = true,
                    CreatedById = 1,
                    CreatedDate = DateTime.Now
                }


                );
        }
    }
}
