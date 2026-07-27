using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Builder
{
    public class EmployeeDirector
    {
        public Employee CreateEmployee(
            IEmployeeBuilder builder,
            string name,
            string department,
            double salary,
            string type)
        {
            builder.SetName(name);
            builder.SetDepartment(department);
            builder.SetSalary(salary);
            builder.SetEmployeeType(type);

            return builder.GetEmployee();
        }
    }
}