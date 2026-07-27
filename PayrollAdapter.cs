namespace EmployeeManagementAPI.Adapter
{
    public class PayrollAdapter : IPayrollService
    {
        private readonly ThirdPartyPayroll _payroll =
            new ThirdPartyPayroll();

        public void ProcessSalary(
            string name,
            double salary)
        {
            _payroll.SendPayment(name, salary);
        }
    }
}