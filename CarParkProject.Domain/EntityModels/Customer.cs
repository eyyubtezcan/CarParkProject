using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{
    [Table("Customers")]
    public class Customer: BaseEntity
    {
        public string TCNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address{ get; set; } //Later will split with addresses entitymodel
        //public ICollection<Vehicle> Vehicles{ get; set; }
        //public ICollection<Ticket> Tickets { get; set; }
    }
}
