using EmployeeManagementAPI.Facade;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        private readonly EmployeeFacade _facade;

        public EmployeesController(
            IEmployeeRepository repository,
            EmployeeFacade facade)
        {
            _repository = repository;
            _facade = facade;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = _repository.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _facade.AddEmployee(employee);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            try
            {
                employee.Id = id;

                _repository.Update(employee);
                _repository.Save();

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _repository.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            _repository.Delete(id);
            _repository.Save();

            return Ok($"Employee {id} deleted successfully.");
        }
    }
}
