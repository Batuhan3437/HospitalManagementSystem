﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class Admin : User
    {
        public DateTime startDateOfEmployment { get; set; }
        public User user { get; set; }
    }
}
