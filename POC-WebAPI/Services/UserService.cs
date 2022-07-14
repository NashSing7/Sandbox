using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;


namespace POC_WebAPI
{
    public class UserService : IUser
    {
        private List<User> _userList;
        private readonly IDapper _dapper;
        public UserService(IDapper dapper)
        {
            _dapper = dapper;

            _userList = new List<User>
            {
                new User() { UserId = 1, UserName = "Test1", DateCreated = DateTime.UtcNow },
                new User() { UserId = 2, UserName = "Test2", DateCreated = DateTime.UtcNow },
                new User() { UserId = 3, UserName = "Test3", DateCreated = DateTime.UtcNow }

            };

        }
        public IEnumerable<User> GetAllUsers()
        {
  

            return _userList;
        }
    }

}