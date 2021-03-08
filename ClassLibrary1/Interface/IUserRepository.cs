using DemoApp.Repository.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Repository.Interface
{
  public  interface IUserRepository
    {
        List<User> Get();
        void Add(User user);
    }
}
