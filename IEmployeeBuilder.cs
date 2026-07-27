using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Builder
{
    public interface IEmployeeBuilder
    {
        void SetName(string name);
        void SetDepartment(string department);
        void SetSalary(double salary);
        void SetEmployeeType(string type);

        Employee GetEmployee();
    }
}