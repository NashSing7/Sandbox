using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace POC_WebAPI
{
    public interface IUser
    {
        IEnumerable<User> GetAllUsers();
    }

}