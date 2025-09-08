import React, { useState } from 'react';
import TaskDashboard from './TaskDashboard';
import './App.css';

export default function App() {
  const [role, setRole] = useState('teamMember');
  const [isDarkMode, setIsDarkMode] = useState(false);

  const toggleRole = () => {
    setRole(prevRole => prevRole === 'teamMember' ? 'admin' : 'teamMember');
  };

  const toggleTheme = () => {
    setIsDarkMode(prevMode => !prevMode);
  };

  return (
    <div className={`app-container ${isDarkMode ? 'dark-mode' : ''}`}>
      <header className="app-header">
        <h1 className="app-title">Task Dashboard</h1>
        <div className="header-buttons">
          <button onClick={toggleRole} className="role-toggle">
            Switch to {role === 'teamMember' ? 'Admin' : 'Team Member'}
          </button>
          <button onClick={toggleTheme} className="theme-toggle">
            Toggle Theme
          </button>
        </div>
      </header>

      <TaskDashboard role={role} isDarkMode={isDarkMode} />
    </div>
  );
}