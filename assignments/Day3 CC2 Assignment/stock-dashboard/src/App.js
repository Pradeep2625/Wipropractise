import React, { useState, useEffect } from "react";
import io from "socket.io-client";
import Dashboard from "./components/Dashboard";
import StockInput from "./components/StockInput";
import StockChart from "./components/StockChart";
import "./App.css";

function App() {
  const [stocks, setStocks] = useState([
    { symbol: "AAPL", price: 150.25, change: "+2.50" },
  ]);

  // NEW: Theme state, default is light
  const [theme, setTheme] = useState("light");

  useEffect(() => {
    const socket = io("http://localhost:5000");
    socket.on("stockUpdate", (data) => {
      setStocks((prevStocks) =>
        prevStocks.map((stock) =>
          stock.symbol === data.symbol
            ? { ...stock, price: data.price, change: data.change }
            : stock
        )
      );
    });
    return () => {
      socket.disconnect();
    };
  }, []);

  const handleAddStock = (symbol) => {
    const newStock = {
      symbol,
      price: (Math.random() * 300 + 50).toFixed(2),
      change: (Math.random() * 20 - 10).toFixed(2),
    };
    setStocks((prev) => [...prev, newStock]);
  };

  // NEW: Toggle between 'light' and 'dark'
  const toggleTheme = () => {
    setTheme((prevTheme) => (prevTheme === "light" ? "dark" : "light"));
  };

  return (
    <div className={`App ${theme}`}>
      {" "}
      {/* Apply theme as a CSS class */}
      <div className="container-fluid">
        {/* Theme toggle button */}
        <div className="text-end my-3">
          <button className="btn btn-secondary" onClick={toggleTheme}>
            Switch to {theme === "light" ? "Dark" : "Light"} Theme
          </button>
        </div>
        <Dashboard stocks={stocks} theme={theme} />
        <StockInput onAddStock={handleAddStock} />
        <StockChart theme={theme} />
      </div>
    </div>
  );
}

export default App;
