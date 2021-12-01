using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreSessionmanagementApplication.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public  string Location { get; set; }

        public Company Company { get; set; }
    }
}
