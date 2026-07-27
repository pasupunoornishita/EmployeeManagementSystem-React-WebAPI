using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Factory
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee(string type)
        {
            return new Employee
            {
                EmployeeType = type
            };
        }
    }
}