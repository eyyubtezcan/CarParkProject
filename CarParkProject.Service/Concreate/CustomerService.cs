using CarParkProject.Data.Core.Abstract;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Concreate
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        public CustomerService(IUnitOfWork unitOfWork, IRepository<Customer> repository) :
       base(unitOfWork, repository)
        {
        }

    }
}
