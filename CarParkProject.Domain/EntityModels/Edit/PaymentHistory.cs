using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.EntityModels
{
    [Table("PaymentHistory")]
    public class PaymentHistory : BaseEntity
    {
        public string Description { get; set; }
        public string LicenceNumber { get; set; }
        public decimal ParkingFees { get; set; }
        public DateTime PayDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public bool IsSubscription { get; set; }
    }
}
