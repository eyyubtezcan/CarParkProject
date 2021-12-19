using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{

    [Table("Vehicles")]
    public class Vehicle : BaseEntity
    { 
        public string Description{ get; set; }
        public string LicenceNumber { get; set; }
        public string ChassisNumber { get; set; }
        public DateTime RegistrationYear { get; set; }
        public int ColorId { get; set; }
        public int FuelTypeId { get; set; }
        public int ModelId { get; set; }
        public int CustomerId { get; set; }
        //[NotMapped]
        //public virtual Customer Customer{ get; set; }
        //[NotMapped]
        //public virtual VehicleModel Model { get; set; }
        //[NotMapped]
        //public virtual VehicleColor Color { get; set; }
        //[NotMapped]
        //public virtual VehicleFuelType FuelType { get; set; }


    }
}
