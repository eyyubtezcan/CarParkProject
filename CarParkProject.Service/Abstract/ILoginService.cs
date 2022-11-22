using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface ILoginService
    {
        ServiceResult<User> Login(LoginVM model);
        ServiceResult<bool> IsLoggedIn(string token, string sessionId, int userId);
    }
}
