﻿using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data.Repositories.Concreate
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

    }
}
