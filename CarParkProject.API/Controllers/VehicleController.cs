using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Domain.EntityModels;
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

    public class VehicleController : Controller
    {
        IVehicleService _vehicleService;
  
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        // GET: api/Vehicle
          [HttpGet("GetVehicles")]
       
        public IEnumerable<Vehicle> GetVehicles()
        {

            return _vehicleService.GetAllVehiclesAsync().Result; 
        }
        // GET: api/Customer
        [HttpPost("AddVehicle")]

        public Task<Vehicle> AddCustomers(Vehicle vehicle)
        {


            return _vehicleService.AddVehicle(vehicle);
        }

    }
}
