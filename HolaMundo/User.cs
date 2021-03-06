﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class User
    {
        // int id;
        // public int Id
        // {
        //get => id;
        //set => id = value;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RememberToken { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
