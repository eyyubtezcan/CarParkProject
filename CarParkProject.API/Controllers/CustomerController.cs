using CarParkProject.API.Controllers.Base;
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

    public class CustomerController : BaseController
    {
        ICustomerService _CustomerService;

        public CustomerController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }
        // GET: api/Customer
        [HttpGet("GetCustomers")]

        public async Task<List<CustomerVM>> GetCustomers()
        {

            try
            {
                var customers = await Task.FromResult(_CustomerService.GetAllCustomers());
                return customers;
            }
            catch (Exception e)
            {

                throw;
            }


        }

        // GET: api/Customer
        [HttpPost("AddCustomer")]

        public Task<Customer> AddCustomers(Customer customer)
        {


            return _CustomerService.AddCustomer(customer);
        }

    }
}
