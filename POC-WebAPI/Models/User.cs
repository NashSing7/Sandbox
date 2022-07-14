using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace POC_WebAPI
{
    public class User
    {
        public int UserId { get; set;}
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
    }

}