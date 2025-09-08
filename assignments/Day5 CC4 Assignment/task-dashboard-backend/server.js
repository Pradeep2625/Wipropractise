// This file sets up a Node.js backend using Express and WebSockets (Socket.io)
// to handle real-time task management.

// Import necessary modules.
const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");

// Initialize Express app.
const app = express();
// Create an HTTP server using the Express app.
const server = http.createServer(app);

// Configure the WebSocket server to use the HTTP server.
// The 'cors' option allows the frontend from a different origin to connect.
const io = new Server(server, {
  cors: {
    origin: "*", // Allow all origins for development purposes.
    methods: ["GET", "POST"]
  },
});

// Use the cors middleware for Express.
app.use(cors());
// Use the express.json() middleware to parse JSON requests.
app.use(express.json());

// In-memory task storage. In a real-world application, this would be a database.
let tasks = [
  { id: 1, title: 'Write a new blog post', assignee: 'teamMember', description: 'Draft a blog post for the company website.', deadline: '2025-09-01' },
  { id: 2, title: 'Review PR #123', assignee: 'admin', description: 'Review pull request for new feature.', deadline: '2025-08-30' },
  { id: 3, title: 'Update documentation', assignee: 'teamMember', description: 'Update API documentation.', deadline: '2025-09-05' },
];

// WebSocket connection handler.
io.on("connection", (socket) => {
  console.log("A user connected:", socket.id);

  // Send the current list of tasks to the newly connected client.
  socket.on("loadTasks", () => {
    socket.emit("loadTasks", tasks);
  });

  // Handle 'addTask' event from a client.
  socket.on("addTask", (task) => {
    // Add the new task to our in-memory storage.
    tasks.push(task);
    // Broadcast the updated task list to all connected clients.
    io.emit("taskUpdated", tasks);
    io.emit("taskNotification", { message: `New task added: ${task.title}`, assignee: task.assignee });
    console.log("Task added:", task.title, "Assignee:", task.assignee);
  });

  // Handle 'updateTask' event from a client.
  socket.on("updateTask", (updatedTask) => {
    // Update the task in our in-memory storage.
    tasks = tasks.map(task => task.id === updatedTask.id ? updatedTask : task);
    // Broadcast the updated task list to all connected clients.
    io.emit("taskUpdated", tasks);
    io.emit("taskNotification", { message: `Task updated: ${updatedTask.title}`, assignee: updatedTask.assignee });
    console.log("Task updated:", updatedTask.title, "Assignee:", updatedTask.assignee);
  });

  // Handle 'deleteTask' event from a client.
  socket.on("deleteTask", (taskId) => {
    // Find the deleted task for notification.
    const deletedTask = tasks.find(task => task.id === taskId);
    // Filter out the task with the given ID.
    tasks = tasks.filter(task => task.id !== taskId);
    // Broadcast the updated task list to all connected clients.
    io.emit("taskUpdated", tasks);
    if (deletedTask) {
      io.emit("taskNotification", { message: `Task deleted: ${deletedTask.title}`, assignee: deletedTask.assignee });
    }
    console.log("Task deleted with ID:", taskId);
  });

  // Handle client disconnection.
  socket.on("disconnect", () => {
    console.log("User disconnected:", socket.id);
  });
});

// Start the server on port 5000.
server.listen(5000, () => {
  console.log("Server is running on port 5000");
});