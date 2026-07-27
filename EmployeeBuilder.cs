using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Builder
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        private Employee _employee = new Employee();

        public void SetName(string name)
        {
            _employee.Name = name;
        }

        public void SetDepartment(string department)
        {
            _employee.Department = department;
        }

        public void SetSalary(double salary)
        {
            _employee.Salary = salary;
        }

        public void SetEmployeeType(string type)
        {
            _employee.EmployeeType = type;
        }

        public Employee GetEmployee()
        {
            return _employee;
        }
    }
}