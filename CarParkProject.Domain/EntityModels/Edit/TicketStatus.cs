using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{
    [Table("TicketStatuses")]
    public class TicketStatus : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
       public ICollection<Ticket> Tickets { get; set; }
    }
}
