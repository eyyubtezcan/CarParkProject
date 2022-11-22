using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface IRoleService
    {
        ServiceResult<Role> InsertRole(Role role);
        ServiceResult<List<Role>> GetRoles();
       
    }
}
