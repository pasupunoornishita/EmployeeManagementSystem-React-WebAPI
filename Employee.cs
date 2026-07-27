namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        public double Salary { get; set; }

        public string EmployeeType { get; set; } = string.Empty;
    }
}