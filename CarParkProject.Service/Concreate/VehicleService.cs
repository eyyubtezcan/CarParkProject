using CarParkProject.Core.Abstract;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Data.UnitOfWorks;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
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
        private readonly IRepository<VehicleBrand> _vehicleBrand;
        private readonly IRepository<VehicleModel> _vehicleModel;
        private readonly IRepository<VehicleCategory> _vehicleCategory;
        //private readonly IUnitOfWork _unitOfWork;
        public VehicleService(
            IRepository<VehicleBrand> vehicleBrand,
            IRepository<VehicleModel> vehicleModels,
            IRepository<VehicleCategory> vehicleCategory,

            IVehicleRepository vehicleRepository) :
       base(vehicleRepository)
        {
            this._vehicleBrand = vehicleBrand;
            this._vehicleModel = vehicleModels;
            this._vehicleCategory = vehicleCategory;
            this._vehicle = vehicleRepository;
        }

        public ServiceResult<List<Vehicle>> GetVehicles(VehicleFilterModel filterModel)
        {
            ServiceResult<List<Vehicle>> res = new ServiceResult<List<Vehicle>>();

            try
            {
                var list = _vehicle.GetAllAsync().Result;
                if (filterModel is null)
                {
                    res.Result = list.ToList();
                    res.Ok();
                    return res;
                }
                else
                {
                    if (filterModel.CustomerId is not null)
                    {
                        list = list.Where(x => x.CustomerId == filterModel.CustomerId);
                    }
                    if (filterModel.UnpaidBalance == true)
                    {
                        //vehicles = vehicles.Where(x => x.CustomerId == filterModel.CustomerId);
                    }
                    if (filterModel.BrandIds.Count > 0)
                    {
                        //vehicles = vehicles.Where(x => x.Model.BrandId.Contains(filterModel.BrandIds));
                    }

                }
                res.Result = list.ToList();
                res.Ok();

            }
            catch (Exception ex)
            {
                res.Fail();
            }
            return res;


        }
        public ServiceResult<Vehicle> AddVehicle(Vehicle vehicle)
        {
            ServiceResult<Vehicle> res = new ServiceResult<Vehicle>();
            try
            {
                _vehicle.AddAsync(vehicle);
                res.Result = vehicle;
                res.Ok();
            }
            catch (Exception)
            {
                res.Fail();
            }
            return res;
        }
        public ServiceResult<List<VehicleBrand>> GetVehicleBrands()
        {
            ServiceResult<List<VehicleBrand>> res = new ServiceResult<List<VehicleBrand>>();

            try
            {
                var list = _vehicleBrand.GetAllAsync().Result;

                res.Result = list.ToList();
                res.Ok();
                return res;

            }
            catch (Exception ex)
            {
                res.Fail();
            }
            return res;
        }

        public ServiceResult<List<VehicleCategory>> GetVehicleCategories()
        {
            ServiceResult<List<VehicleCategory>> res = new ServiceResult<List<VehicleCategory>>();

            try
            {
                var list = _vehicleCategory.GetAllAsync().Result;

                res.Result = list.ToList();
                res.Ok();
                return res;

            }
            catch (Exception ex)
            {
                res.Fail();
            }
            return res;
        }

        public ServiceResult<List<VehicleModel>> GetVehicleModels()
        {
            ServiceResult<List<VehicleModel>> res = new ServiceResult<List<VehicleModel>>();

            try
            {
                var list = _vehicleModel.GetAllAsync().Result;

                res.Result = list.ToList();
                res.Ok();
                return res;

            }
            catch (Exception ex)
            {
                res.Fail();
            }
            return res;
        }


    }
}
