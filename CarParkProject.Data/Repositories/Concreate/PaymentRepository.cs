using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data.Repositories.Concreate
{
    public class PaymentRepository : Repository<Ticket>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {
        }

    }
}
