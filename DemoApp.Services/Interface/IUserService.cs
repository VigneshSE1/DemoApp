using DemoApp.Models.ViewModels;
using DemoApp.Repository.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Services.Interface
{
  public  interface IUserService
    {
        List<User> Get();

        void Add(UserViewModel userViewModel);
    }
}
