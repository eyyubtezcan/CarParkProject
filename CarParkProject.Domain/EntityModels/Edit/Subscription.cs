using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.EntityModels
{
    [Table("Subscription")]
    public class Subscription : BaseEntity
    {
        public string Description { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime ValidityDate { get; set; }

        public Subscription()
        {
            IsActive = false;
        }
    }
}
