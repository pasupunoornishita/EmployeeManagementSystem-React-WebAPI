import axios from 'axios';

const API =
  'http://localhost:5286/api/Employees';

class EmployeeService {

  getEmployees() {
    return axios.get(API);
  }

  getEmployee(id) {
    return axios.get(`${API}/${id}`);
  }

  createEmployee(employee) {
    return axios.post(API, employee);
  }

  updateEmployee(id, employee) {
    return axios.put(
      `${API}/${id}`,
      employee
    );
  }

  deleteEmployee(id) {
    return axios.delete(`${API}/${id}`);
  }
}

export default new EmployeeService();