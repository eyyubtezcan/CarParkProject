using CarParkProject.Core.Abstract;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Data.UnitOfWorks;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Domain.ViewModels;
using CarParkProject.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Concreate
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customer;
        public CustomerService(ICustomerRepository repository) :
       base(repository)
        {
            this._customer = repository;
        }

        public Task<Customer> AddCustomer(Customer customer)
        {
            var deneme = _customer.AddAsync(customer);

            return null;
        }
       

        public List<CustomerVM> GetAllCustomers()
        {
            var customers = _customer.GetAllAsync().Result;
            List<CustomerVM> result = new List<CustomerVM>() { };

            foreach (var item in customers)
            {
                result.Add(new CustomerVM()
                {
                    Id = item.Id,
                    TCNumber = item.TCNumber,
                    Address = item.Address,
                    Email = item.Email,
                    Name = item.Name,
                    Surname = item.Surname,
                    PhoneNumber = item.PhoneNumber,
                });
            }


            return result;

        }

        public ServiceResult<User> GetCustumers(CustomerFilterModel filterModel)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Customer> InsertCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Customer> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        public ServiceResult<Customer> DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
