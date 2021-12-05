using CarParkProject.Data.Core.Abstract;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Data.Repositories.Concreate;
using CarParkProject.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private Repository<Vehicle> _vehicleRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Repository<Vehicle> VehicleRepository
        {
            get
            {

                if (_vehicleRepository == null)
                {
                    _vehicleRepository = new Repository<Vehicle>(_context);
                }
                return _vehicleRepository;
            }
        }

       

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
