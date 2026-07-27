namespace EmployeeManagementAPI.Strategy
{
    public class FullTimeSalaryStrategy : ISalaryStrategy
    {
        public double Calculate(double salary)
        {
            return salary + 5000;
        }
    }
}