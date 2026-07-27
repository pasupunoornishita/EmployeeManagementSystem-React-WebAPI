namespace EmployeeManagementAPI.Strategy
{
    public class ContractSalaryStrategy : ISalaryStrategy
    {
        public double Calculate(double salary)
        {
            return salary;
        }
    }
}