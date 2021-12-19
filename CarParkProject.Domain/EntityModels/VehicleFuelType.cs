using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{
    [Table("VehicleFuelTypes")]
    public class VehicleFuelType : BaseEntity
    {
        public string Description { get; set; }
        [NotMapped]
        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
