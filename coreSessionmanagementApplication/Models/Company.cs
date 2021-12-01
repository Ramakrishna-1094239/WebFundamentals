using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreSessionmanagementApplication.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
