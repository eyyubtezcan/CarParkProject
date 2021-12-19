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
        CustomerVM GetSubscriptionDebtDetail();

    }
}
