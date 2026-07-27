namespace EmployeeManagementAPI.Adapter
{
    public class ThirdPartyPayroll
    {
        public void SendPayment(string employee, double amount)
        {
            Console.WriteLine(
                $"Payment of {amount} sent to {employee}");
        }
    }
}