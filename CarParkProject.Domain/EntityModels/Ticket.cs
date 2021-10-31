using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{
    [Table("Tickets")]
    public class Ticket : BaseEntity
    {
        public DateTime In{ get; set; }
        public DateTime Out { get; set; }
        public string LicenceNumber { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
