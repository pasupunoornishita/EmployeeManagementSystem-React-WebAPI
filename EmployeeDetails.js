import React,
{
  useState,
  useEffect
} from 'react';

import {
  useParams
}
from 'react-router-dom';

import EmployeeService
from '../services/EmployeeService';

function EmployeeDetails() {

  const { id } =
    useParams();

  const [employee,
    setEmployee] =
    useState({});

  useEffect(() => {
    EmployeeService
      .getEmployee(id)
      .then(res =>
        setEmployee(res.data));
  }, [id]);

  return (
    <div>

      <h3>
        Employee Details
      </h3>

      <p>
        <b>ID:</b>
        {employee.id}
      </p>

      <p>
        <b>Name:</b>
        {employee.name}
      </p>

      <p>
        <b>Department:</b>
        {employee.department}
      </p>

      <p>
        <b>Salary:</b>
        {employee.salary}
      </p>

      <p>
        <b>Type:</b>
        {employee.employeeType}
      </p>

    </div>
  );
}

export default EmployeeDetails;