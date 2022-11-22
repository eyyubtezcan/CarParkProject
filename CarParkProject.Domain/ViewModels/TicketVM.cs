using CarParkProject.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.ViewModels
{
    public class TicketVM
    {
        public string Code { get; set; } // when creating will set automatic
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string LicenceNumber { get; set; }
        public VehicleVM Vehicle { get; set; }
        public CustomerVM Customer { get; set; }
        public int StatusId { get; set; } //giriş yapıldı, çıkış yapıldı, ödendi,
        public bool? IsSubscription { get; set; }
        public decimal? ParkingFees { get; set; }
        public DateTime? PayDate { get; set; }
    }
    public class VehicleVM
    {
        public string LicenceNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string ColorDescription { get; set; }
        public string FuelTypeDescription { get; set; }
        public string ModelDescription { get; set; }
        public int ModelId{ get; set; }
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
    }
    enum Status
    {
        CheckIn,
        Payed,
        CheckOut
    }
}

