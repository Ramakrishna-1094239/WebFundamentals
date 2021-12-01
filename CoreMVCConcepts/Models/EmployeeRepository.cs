using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCConcepts.Models
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmployeeId=101,Name="Stu1",salary=30000,Desisgnation="Manager"},
            new Employee(){EmployeeId=102,Name="Stu2",salary=24000,Desisgnation="Dev"},
            new Employee(){EmployeeId=103,Name="Stu3",salary=26000,Desisgnation="Test"},
            new Employee(){EmployeeId=104,Name="Stu4",salary=50000,Desisgnation="Sr.Manager"},

        };


        public void AddEmployee (Employee employee)
        {
            employees.Add(employee);

        }

        public Employee GetEmployeeByID(int employeeId)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == employeeId);

        }


        public IList<Employee> GetEmployee()
        {
            return employees;

        }
    }
}
