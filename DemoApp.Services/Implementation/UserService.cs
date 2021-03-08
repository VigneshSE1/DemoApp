using DemoApp.Models.ViewModels;
using DemoApp.Repository.EntityModels;
using DemoApp.Repository.Interface;
using DemoApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<User> Get()
        {
            return _userRepository.Get();
        }

        public void Add(UserViewModel userViewModel)
        {

            var user = new User()
            {
                Name = userViewModel.Name,
                Role = userViewModel.Role
            };

            _userRepository.Add(user);
            

        }
    }
}
