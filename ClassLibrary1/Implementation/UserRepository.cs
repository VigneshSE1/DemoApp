using DemoApp.Repository.EntityModels;
using DemoApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<User> Get()
        {
            return _dbContext.Users.ToList();
        }

        public void Add(User user)
        {

            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
