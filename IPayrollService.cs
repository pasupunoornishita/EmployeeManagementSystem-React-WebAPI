namespace EmployeeManagementAPI.Adapter
{
    public interface IPayrollService
    {
        void ProcessSalary(string name, double salary);
    }
}