using CarParkProject.Data.Repositories;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data.UnitOfWorks
{
    public interface IUnitOfWork :IDisposable
    {
        Task CommitAsync();
        void Commit();

    }
}
