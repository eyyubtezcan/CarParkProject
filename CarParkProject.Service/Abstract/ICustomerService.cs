﻿using CarParkProject.Domain.EntityModels;
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
        Task<Customer> AddCustomer(Customer customer);

    }
}
