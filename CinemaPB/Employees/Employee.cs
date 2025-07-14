﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.Employees
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string FirstName { get; set; }
        public int IsLocked { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string NameExtension { get; set; }

        public string ContactNo { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int RoleID { get; set; }

        public int StatusID { get; set; }

        public int EmploymentStatus { get; set; }
    }
}
