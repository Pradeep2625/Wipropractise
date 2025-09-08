const express = require("express");
const http = require("http");
const socketIo = require("socket.io");
const cors = require("cors");

const app = express();
const server = http.createServer(app);
const io = socketIo(server, {
  cors: {
    origin: "http://localhost:3000",
    methods: ["GET", "POST"],
  },
});

app.use(cors());
app.use(express.json());

// Basic route
app.get("/", (req, res) => {
  res.send("Stock Market API Server");
});

// Socket.io connection
io.on("connection", (socket) => {
  console.log("User connected:", socket.id);

  // Send stock updates every 3 seconds
  const stockInterval = setInterval(() => {
    const stockUpdate = {
      symbol: "AAPL",
      price: (Math.random() * 200 + 100).toFixed(2),
      change: (Math.random() * 10 - 5).toFixed(2),
      timestamp: new Date(),
    };

    socket.emit("stockUpdate", stockUpdate);
  }, 3000);

  socket.on("disconnect", () => {
    console.log("User disconnected:", socket.id);
    clearInterval(stockInterval);
  });
});

const PORT = process.env.PORT || 5000;
server.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
});
