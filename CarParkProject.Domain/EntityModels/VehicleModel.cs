using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{

    [Table("VehicleModels")]
    public class VehicleModel : BaseEntity
    {
        public string Description { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public virtual VehicleBrand Brand { get; set; }
        public virtual VehicleCategory Category { get; set; }
   
    }
}
