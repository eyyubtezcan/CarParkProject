using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.FilterModels
{
    public class VehicleFilterModel
    {
        public int? CustomerId  { get; set; }
        public int? CategoryId { get; set; }

        public List<int> BrandIds { get; set; }
        public bool? UnpaidBalance { get; set; }
        public VehicleFilterModel()
        {
            CustomerId = null;
            CategoryId = null;
            UnpaidBalance = null;

        }
    }
}
