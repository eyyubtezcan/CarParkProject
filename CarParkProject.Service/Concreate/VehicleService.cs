using CarParkProject.Data.Core.Abstract;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Data.UnitOfWorks;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Concreate
{

    public class VehicleService : Service<Vehicle>, IVehicleService
    {
    private readonly IVehicleRepository _vehicle;
        //private readonly IUnitOfWork _unitOfWork;
        public VehicleService(IVehicleRepository repository) :
       base(repository)
        {
          
            this._vehicle = repository;
        }
        

        public Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return _vehicle.GetAllAsync();
        }
        public Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            var deneme = _vehicle.AddAsync(vehicle);
            return null;
        }


    }
}
