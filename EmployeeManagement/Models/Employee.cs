using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        void Save(Employee employee);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee GetEmployee(int id)
        {
            // Logic to retrieve employee details
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {Id=1, Name="Ahmed", Department="IT"},
                new Employee {Id=2, Name="Semira", Department="Burlington"},
                new Employee {Id=3, Name="Dana", Department="Conduit"},
                new Employee {Id=4, Name="Nebil", Department="Cunningam"}
            };

            return employees.FirstOrDefault(e =>e.Id == id);
        }

        public void Save(Employee employee)
        {
            // Logic to save employee details
        }
    }
}
