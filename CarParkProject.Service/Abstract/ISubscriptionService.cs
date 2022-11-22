using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface ISubscriptionService
    {
        List<CustomerVM> GetAllSubscriptionDebts();
      //view model dönüp metod dönüşündeki veri kullanılabilir
        ServiceResult<bool> CheckSubscription(Vehicle vehicle); //abonelik konrol
        ServiceResult<bool> CheckSubscriptionDebt(Vehicle vehicle); // abonelik borç kontrol
        //SubscriptionVM kullanılabilri veya araç üzerinden oluşturulabilir.
        ServiceResult<bool> CreateSubscription(Vehicle subscription); //abonelik oluşturma
        ServiceResult<bool> EndSubscription(Vehicle subscription); // abonelik sonlandırma
        ServiceResult<bool> UpdateSubscription(Vehicle subscription); //abonelik değişikliği

    }
}
