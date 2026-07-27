import React,
{
  useEffect,
  useState
} from 'react';

import { Link }
from 'react-router-dom';

import EmployeeService
from '../services/EmployeeService';

function EmployeeList() {

  const [employees,
    setEmployees] = useState([]);

  useEffect(() => {
    loadEmployees();
  }, []);

  const loadEmployees = () => {
    EmployeeService
      .getEmployees()
      .then(res =>
        setEmployees(res.data));
  };

  const deleteEmployee = (id) => {
    EmployeeService
      .deleteEmployee(id)
      .then(() => loadEmployees());
  };

  return (
    <div>

      <Link
        to="/create"
        className="btn btn-primary mb-3">

        Add Employee

      </Link>

      <table className="table table-bordered">

        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Department</th>
            <th>Salary</th>
            <th>Type</th>
            <th>Actions</th>
          </tr>
        </thead>

        <tbody>
          {
            employees.map(emp => (
              <tr key={emp.id}>

                <td>{emp.id}</td>
                <td>{emp.name}</td>
                <td>{emp.department}</td>
                <td>{emp.salary}</td>
                <td>{emp.employeeType}</td>

                <td>

                  <Link
                    to={`/details/${emp.id}`}
                    className="btn btn-info me-2">

                    Details

                  </Link>

                  <Link
                    to={`/edit/${emp.id}`}
                    className="btn btn-warning me-2">

                    Edit

                  </Link>

                  <button
                    className="btn btn-danger"
                    onClick={() =>
                      deleteEmployee(emp.id)}>

                    Delete

                  </button>

                </td>

              </tr>
            ))
          }
        </tbody>

      </table>

    </div>
  );
}

export default EmployeeList;