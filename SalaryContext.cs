namespace EmployeeManagementAPI.Strategy
{
    public class SalaryContext
    {
        private readonly ISalaryStrategy _strategy;

        public SalaryContext(ISalaryStrategy strategy)
        {
            _strategy = strategy;
        }

        public double Calculate(double salary)
        {
            return _strategy.Calculate(salary);
        }
    }
}