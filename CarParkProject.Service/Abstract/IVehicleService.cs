using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface IVehicleService
    {
       // Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        ServiceResult<Vehicle> AddVehicle(Vehicle vehicle);
        ServiceResult<List<Vehicle>> GetVehicles(VehicleFilterModel filterModel);
        ServiceResult<List<VehicleBrand>> GetVehicleBrands();
        ServiceResult<List<VehicleModel>> GetVehicleModels();
        ServiceResult<List<VehicleCategory>> GetVehicleCategories();

        
    }
}
