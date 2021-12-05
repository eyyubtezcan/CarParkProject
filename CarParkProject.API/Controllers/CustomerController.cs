using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.ViewModels;
using CarParkProject.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CustomerController : Controller
    {
        ICustomerService _CustomerService;
  
        public CustomerController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }
        // GET: api/Customer
          [HttpGet("GetCustomers")]

        public async Task<List<CustomerVM>>  GetCustomers()
        {
            var customers = await Task.FromResult( _CustomerService.GetAllCustomers());

            return customers;
        }

        // GET: api/Customer
        [HttpPost("AddCustomer")]

        public Task<Customer> AddCustomers(Customer customer)
        {

            
            return _CustomerService.AddCustomer(customer);
        }

    }
}
