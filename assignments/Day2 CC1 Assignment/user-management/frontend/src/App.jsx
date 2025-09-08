import React, { useEffect, useState } from "react";
import axios from "axios";
import UserList from "./UserList";
import UserForm from "./UserForm";
import "./App.css";

function App() {
  const [users, setUsers] = useState([]);

  // fetch users from backend
  useEffect(() => {
    axios.get("http://localhost:5000/users").then((res) => setUsers(res.data));
  }, []);

  // when new user is added
  const handleUserAdded = (newUser) => {
    setUsers((prev) => [...prev, newUser]);
  };

  return (
    <div className="container">
      <h1>User Management System</h1>
      <UserForm onUserAdded={handleUserAdded} />
      <UserList users={users} />
    </div>
  );
}

export default App;
