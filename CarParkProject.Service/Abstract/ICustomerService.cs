using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface ICustomerService
    {
        List<CustomerVM> GetAllCustomers();
        // They will merge with 1 method
        
        #region They will merge with 1 method
        ServiceResult<Customer> InsertCustomer(Customer customer);
        ServiceResult<Customer> UpdateCustomer(Customer customer);
        ServiceResult<Customer> DeleteCustomer(Customer customer);
        #endregion

        ServiceResult<User> GetCustumers(CustomerFilterModel filterModel);
        


    }
}
