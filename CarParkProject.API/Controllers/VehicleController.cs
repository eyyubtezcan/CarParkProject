using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Service;
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
        [HttpPost("GetVehicles")]

        public IActionResult GetVehicles(VehicleFilterModel filterModel)
        {
            var vehicles = _vehicleService.GetVehicles(filterModel);
            if (vehicles.isOk)
            {
                return Ok(vehicles);
            }
            else
            {
                return StatusCode(500, $"Internal server error:");
            }
            //TODO: Gelenleri log tutmak  için sonradan eklenecek
            // _logger.LogInfo($"Returned all owners from database.");

        }
        // GET: api/Vehicle
        [HttpPost("AddVehicle")]

        public IActionResult AddCustomers(Vehicle vehicle)
        {


            var vehicles = _vehicleService.AddVehicle(vehicle);
            if (vehicles.isOk)
            {
                return Ok(vehicles);
            }
            else
            {
                return StatusCode(500, $"Internal server error:");
            }
            //TODO: Gelenleri log tutmak  için sonradan eklenecek
            // _logger.LogInfo($"Returned all owners from database.");
        }
        // GET: api/Vehicle
        [HttpPost("GetBrands")]

        public IActionResult GetVehicleBrands()
        {
            var brands = _vehicleService.GetVehicleBrands();
            if (brands.isOk)
            {
                return Ok(brands);
            }
            else
            {
                return StatusCode(500, $"Internal server error:");
            }
            //TODO: Gelenleri log tutmak  için sonradan eklenecek
            // _logger.LogInfo($"Returned all owners from database.");

        }
        [HttpPost("GetModels")]

        public IActionResult GetVehicleModels()
        {
            var models = _vehicleService.GetVehicleModels();
            if (models.isOk)
            {
                return Ok(models);
            }
            else
            {
                return StatusCode(500, $"Internal server error:");
            }
            //TODO: Gelenleri log tutmak  için sonradan eklenecek
            // _logger.LogInfo($"Returned all owners from database.");

        }
        [HttpPost("GetCategory")]

        public IActionResult GetVehicleCategories()
        {
            var categories = _vehicleService.GetVehicleCategories();
            if (categories.isOk)
            {
                return Ok(categories);
            }
            else
            {
                return StatusCode(500, $"Internal server error:");
            }
            //TODO: Gelenleri log tutmak  için sonradan eklenecek
            // _logger.LogInfo($"Returned all owners from database.");

        }
    }
}
