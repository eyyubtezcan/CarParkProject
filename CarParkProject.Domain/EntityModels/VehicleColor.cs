using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{

    [Table("VehicleColors")]
    public class VehicleColor : BaseEntity
    {
        public string Description { get; set; }
        public string Code { get; set; }
        [NotMapped]
        public ICollection<Vehicle> Vehicles { get; set; }


    }
}
