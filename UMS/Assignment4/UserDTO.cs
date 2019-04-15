﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public char gender { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string nic { get; set; }
        public DateTime dob { get; set; 
        }
        public int cricket { get; set; }
        public int hockey { get; set; }
        public int chess { get; set; }
        public string imageName { get; set; }
        public DateTime createdOn { get; set;}
        public string email { get; set; }
    }
}
