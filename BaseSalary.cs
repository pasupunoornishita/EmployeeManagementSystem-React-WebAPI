namespace EmployeeManagementAPI.Decorator
{
    public class BaseSalary : ISalaryComponent
    {
        private readonly double _salary;

        public BaseSalary(double salary)
        {
            _salary = salary;
        }

        public double GetSalary()
        {
            return _salary;
        }
    }
}