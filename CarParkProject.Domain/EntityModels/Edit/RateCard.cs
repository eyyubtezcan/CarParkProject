using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.EntityModels
{
    [Table("RateCards")]
    public class RateCard : BaseEntity
    {
        public string Description { get; set; }
        public int VehicleCategoryId { get; set; }
        public decimal HourlyPrice { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal SubscriptionPrice { get; set; }
     //   public DateTime ValidityDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

}
