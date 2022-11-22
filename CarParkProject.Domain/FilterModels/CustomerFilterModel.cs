using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.FilterModels
{
    public class CustomerFilterModel
    {
        public int? CustomerId  { get; set; }
        public int? CategoryId { get; set; }
        public bool? UnpaidBalance { get; set; }
        public CustomerFilterModel()
        {
            CustomerId = null;
            CategoryId = null;
            UnpaidBalance = null;

        }
    }
}
