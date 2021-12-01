using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCConcepts.Models
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetEmployee();

        Employee GetEmployeeByID(int employeeId);

        void AddEmployee(Employee employee);
    }
}
