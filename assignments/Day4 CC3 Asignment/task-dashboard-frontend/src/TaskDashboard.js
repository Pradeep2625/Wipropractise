import React, { useState, useEffect } from 'react';
import io from 'socket.io-client';

export default function TaskDashboard({ role, isDarkMode }) {
  const [tasks, setTasks] = useState([]);
  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');
  const [deadline, setDeadline] = useState('');
  const [assignee, setAssignee] = useState(role);
  const [editingId, setEditingId] = useState(null);
  const [notifications, setNotifications] = useState([]);

  useEffect(() => {
    const socket = io('http://localhost:5000');
    
    socket.on('connect', () => {
      console.log('Connected to WebSocket server');
      socket.emit('loadTasks');
    });

    socket.on('loadTasks', (loadedTasks) => {
      setTasks(loadedTasks);
    });

    socket.on('taskUpdated', (updatedTasks) => {
      setTasks(updatedTasks);
    });

    socket.on('taskNotification', (notif) => {
      if (notif.assignee === role || role === 'admin') {
        setNotifications(prev => [...prev, notif.message]);
      }
    });

    return () => {
      socket.disconnect();
      console.log('Disconnected from WebSocket server');
    };
  }, [role]);

  const handleSubmit = () => {
    if (title.trim() !== '') {
      const task = {
        id: editingId || Date.now(),
        title,
        description,
        deadline,
        assignee: role === 'admin' ? assignee : role, // Team members can't change assignee
      };
      
      if (editingId) {
        io('http://localhost:5000').emit('updateTask', task);
        setEditingId(null);
      } else {
        io('http://localhost:5000').emit('addTask', task);
      }
      
      setTitle('');
      setDescription('');
      setDeadline('');
      setAssignee(role);
    }
  };

  const handleEditTask = (task) => {
    setTitle(task.title);
    setDescription(task.description || '');
    setDeadline(task.deadline || '');
    setAssignee(task.assignee);
    setEditingId(task.id);
  };

  const handleDeleteTask = (taskId) => {
    io('http://localhost:5000').emit('deleteTask', taskId);
  };

  const visibleTasks = role === 'admin' ? tasks : tasks.filter(task => task.assignee === role);

  return (
    <main className="dashboard-container">
      <div className="dashboard-card">
        <h2 className="dashboard-title">
          {role === 'admin' ? 'Admin Dashboard' : 'Team Member Dashboard'}
        </h2>
        
        <div className="input-section">
          <input
            type="text"
            placeholder="Enter task title..."
            value={title}
            onChange={(e) => setTitle(e.target.value)}
            className="task-input"
          />
          <textarea
            placeholder="Enter task description..."
            value={description}
            onChange={(e) => setDescription(e.target.value)}
            className="task-textarea"
          />
          <input
            type="date"
            value={deadline}
            onChange={(e) => setDeadline(e.target.value)}
            className="task-input"
          />
          {role === 'admin' && (
            <select
              value={assignee}
              onChange={(e) => setAssignee(e.target.value)}
              className="task-select"
            >
              <option value="teamMember">Team Member</option>
              <option value="admin">Admin</option>
            </select>
          )}
          <button
            onClick={handleSubmit}
            className="add-task-btn"
          >
            {editingId ? 'Update Task' : 'Add Task'}
          </button>
        </div>

        <div className="notifications">
          <h3>Notifications</h3>
          <ul>
            {notifications.map((msg, index) => (
              <li key={index}>{msg}</li>
            ))}
          </ul>
          {notifications.length > 0 && (
            <button onClick={() => setNotifications([])} className="clear-btn">
              Clear Notifications
            </button>
          )}
        </div>
        
        <ul className="task-list">
          {visibleTasks.length > 0 ? (
            visibleTasks.map(task => (
              <li key={task.id} className={`task-item ${task.assignee}`}>
                <div className="task-info">
                  <span className="task-title">{task.title}</span>
                  {task.description && <p className="task-description">{task.description}</p>}
                  <span className="task-deadline">Deadline: {task.deadline || 'None'}</span>
                  <span className="task-assignee">Assignee: {task.assignee}</span>
                </div>
                <div className="task-actions">
                  {(role === 'admin' || task.assignee === role) && (
                    <>
                      <button
                        onClick={() => handleEditTask(task)}
                        className="edit-btn"
                      >
                        Edit
                      </button>
                      <button
                        onClick={() => handleDeleteTask(task.id)}
                        className="delete-btn"
                      >
                        Delete
                      </button>
                    </>
                  )}
                </div>
              </li>
            ))
          ) : (
            <p className="no-tasks">No tasks assigned to you.</p>
          )}
        </ul>
      </div>
    </main>
  );
}