﻿using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{

    [Table("VehicleBrands")]
    public class VehicleBrand : BaseEntity
    {
        public string Description { get; set; }
        [NotMapped]
        public ICollection<VehicleModel> VehicleModels{ get; set; }

    }
}
