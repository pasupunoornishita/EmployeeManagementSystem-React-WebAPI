using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository;
using EmployeeManagementAPI.Strategy;
using EmployeeManagementAPI.Singleton;

namespace EmployeeManagementAPI.Facade
{
    public class EmployeeFacade
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeFacade(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public void AddEmployee(Employee employee)
        {
            ISalaryStrategy strategy;

            if (employee.EmployeeType == "FullTime")
                strategy = new FullTimeSalaryStrategy();
            else
                strategy = new ContractSalaryStrategy();

            SalaryContext context =
                new SalaryContext(strategy);

            employee.Salary =
                context.Calculate(employee.Salary);

            _repository.Add(employee);

            _repository.Save();

            Logger.Instance.Log(
                $"Employee {employee.Name} Added");
        }
    }
}