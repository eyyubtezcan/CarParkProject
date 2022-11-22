using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface IUserService
    {
        ServiceResult<User> AddUser(User user);
        ServiceResult<List<User>> GetUsers(UserFilterModel filterModel);
        ServiceResult<User> GetLoginUser(LoginVM user);

    }
}
