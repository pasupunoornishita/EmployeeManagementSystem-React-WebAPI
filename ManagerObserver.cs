namespace EmployeeManagementAPI.Observer
{
    public class ManagerObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Manager Notification: {message}");
        }
    }
}