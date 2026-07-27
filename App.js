import { BrowserRouter, Routes, Route }
from 'react-router-dom';

import EmployeeList
from './components/EmployeeList';

import CreateEmployee
from './components/CreateEmployee';

import EditEmployee
from './components/EditEmployee';

import EmployeeDetails
from './components/EmployeeDetails';

function App() {
  return (
    <BrowserRouter>
      <div className="container mt-4">

        <h2 className="text-center">
          Employee Management System
        </h2>

        <Routes>
          <Route
            path="/"
            element={<EmployeeList />}
          />

          <Route
            path="/create"
            element={<CreateEmployee />}
          />

          <Route
            path="/edit/:id"
            element={<EditEmployee />}
          />

          <Route
            path="/details/:id"
            element={<EmployeeDetails />}
          />
        </Routes>

      </div>
    </BrowserRouter>
  );
}

export default App;