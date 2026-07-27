using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.Id);

            if (existingEmployee == null)
            {
                throw new Exception("Employee not found");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Department = employee.Department;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.EmployeeType = employee.EmployeeType;
        }

        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}