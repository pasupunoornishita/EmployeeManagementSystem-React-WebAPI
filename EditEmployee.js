import React,
{
  useState,
  useEffect
} from 'react';

import {
  useNavigate,
  useParams
}
from 'react-router-dom';

import EmployeeService
from '../services/EmployeeService';

function EditEmployee() {

  const { id } =
    useParams();

  const navigate =
    useNavigate();

  const [employee,
    setEmployee] =
    useState({});

  useEffect(() => {
    EmployeeService
      .getEmployee(id)
      .then(res =>
        setEmployee(res.data));
  }, [id]);

  const handleChange = (e) => {
    setEmployee({
      ...employee,
      [e.target.name]:
      e.target.value
    });
  };

  const updateEmployee = (e) => {
    e.preventDefault();

    EmployeeService
      .updateEmployee(
        id,
        employee
      )
      .then(() => navigate('/'));
  };

  return (
    <form onSubmit={updateEmployee}>

      <input
        className="form-control mb-2"
        value={employee.name || ''}
        name="name"
        onChange={handleChange}
      />

      <input
        className="form-control mb-2"
        value={employee.department || ''}
        name="department"
        onChange={handleChange}
      />

      <input
        className="form-control mb-2"
        value={employee.salary || ''}
        name="salary"
        onChange={handleChange}
      />

      <button
        className="btn btn-primary">

        Update

      </button>

    </form>
  );
}

export default EditEmployee;