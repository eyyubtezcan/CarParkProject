using CarParkProject.Core.Abstract;
using CarParkProject.Data.Repositories.Abstract;
using CarParkProject.Data.UnitOfWorks;
using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.FilterModels;
using CarParkProject.Domain.ViewModels;
using CarParkProject.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarParkProject.Service.Concreate
{
    public class LoginService : Service<User>,ILoginService
    {
        private readonly IUserService _userService;
        private readonly ILoginRepository _repository;
        private readonly IUserRepository _userRepository;
       


        public LoginService(ILoginRepository repository, IUserService userService, IUserRepository userRepository) :
       base(repository)
        {
            this._repository = repository;
            this._userService = userService;
            this._userRepository = userRepository;
        }

        public ServiceResult<bool> IsLoggedIn(string token, string sessionId, int userId)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<User> Login(LoginVM model)
        {
            //this.ValidateUser(model);
            if (model == null)
            {
                throw new FormatException("invalid username and/or password");
            }
          
            //var username = ((string.IsNullOrEmpty(model.UserName)) ? model.Email : model.UserName).ToLower();
            UserFilterModel userfilterModel = new UserFilterModel()
            {
                Email = model.Email,
                UserName = model.UserName
            };
            var userData = _userService.GetUsers(userfilterModel).Result.FirstOrDefault();
            // var userData = _userRepository.GetAllAsync().Result.Where(x=>x.)

         //Gelen şifre encrypt edilerek dbdeki ile karşılaştırılacak
            if (model.Password==userData.EncryptedPassword)
            {

            }
            throw new NotImplementedException();
        }

     
    }
}
