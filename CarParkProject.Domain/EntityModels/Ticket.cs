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
        public string Code { get; set; } // when creating will set automatic
        public DateTime CheckIn{ get; set; }
        public DateTime CheckOut { get; set; }
        public string LicenceNumber { get; set; }
        public int? VehicleId { get; set; }
        public int StatusId { get; set; }
        //public string CheckInPhoto { get; set; } => I will add fueture.
        //public string CheckOutPhoto { get; set; } => I will add fueture.
        public virtual Vehicle Vehicle { get; set; }
        public virtual TicketStatus Status { get; set; }
    }
}
