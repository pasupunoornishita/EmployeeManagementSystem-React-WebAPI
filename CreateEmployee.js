import React,
{
  useState
} from 'react';

import { useNavigate }
from 'react-router-dom';

import EmployeeService
from '../services/EmployeeService';

function CreateEmployee() {

  const navigate =
    useNavigate();

  const [employee,
    setEmployee] =
    useState({
      name: '',
      department: '',
      salary: '',
      employeeType: 'FullTime'
    });

  const handleChange = (e) => {
    setEmployee({
      ...employee,
      [e.target.name]:
      e.target.value
    });
  };

  const saveEmployee = (e) => {
    e.preventDefault();

    EmployeeService
      .createEmployee(employee)
      .then(() => navigate('/'));
  };

  return (
    <form onSubmit={saveEmployee}>

      <input
        className="form-control mb-2"
        placeholder="Name"
        name="name"
        onChange={handleChange}
      />

      <input
        className="form-control mb-2"
        placeholder="Department"
        name="department"
        onChange={handleChange}
      />

      <input
        className="form-control mb-2"
        placeholder="Salary"
        name="salary"
        onChange={handleChange}
      />

      <select
        className="form-control mb-2"
        name="employeeType"
        onChange={handleChange}>

        <option>
          FullTime
        </option>

        <option>
          Contract
        </option>

      </select>

      <button
        className="btn btn-success">

        Save

      </button>

    </form>
  );
}

export default CreateEmployee;