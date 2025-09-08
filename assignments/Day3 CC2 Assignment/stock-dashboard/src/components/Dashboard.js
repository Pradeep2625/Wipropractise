import React, { useState, useEffect } from "react";
import "bootstrap/dist/css/bootstrap.css";

function Dashboard({ stocks: propStocks }) {
  // useState manages component state
  const [stocks, setStocks] = useState(
    propStocks || [
      { symbol: "AAPL", price: 150.25, change: "+2.50" },
      { symbol: "GOOGL", price: 2800.45, change: "-15.30" },
      { symbol: "MSFT", price: 310.75, change: "+5.25" },
    ]
  );
  const [loading, setLoading] = useState(true);

  // This is like componentDidMount - runs once when component loads
  useEffect(() => {
    console.log("Component mounted - fetching initial stock data");
    fetchStockData();
  }, []); // Empty array means this runs once when component loads

  // This is like componentDidUpdate - runs when stocks change
  useEffect(() => {
    console.log("Stocks updated:", stocks);
  }, [stocks]); // Runs whenever stocks array changes

  // This simulates componentWillUnmount - cleanup when component is removed
  useEffect(() => {
    return () => {
      console.log("Component will unmount - cleanup here");
    };
  }, []);

  const fetchStockData = async () => {
    try {
      setLoading(true);
      // Simulate API call delay
      setTimeout(() => {
        setStocks([
          { symbol: "AAPL", price: 150.25, change: "+2.50" },
          { symbol: "GOOGL", price: 2800.45, change: "-15.30" },
          { symbol: "MSFT", price: 310.75, change: "+5.25" },
          { symbol: "TSLA", price: 850.4, change: "+12.80" },
        ]);
        setLoading(false);
      }, 1000);
    } catch (error) {
      console.error("Error fetching stock data:", error);
      setLoading(false);
    }
  };

  // Show loading spinner while data is being fetched
  if (loading) {
    return (
      <div className="text-center mt-5">
        <div className="spinner-border" role="status">
          <span className="visually-hidden">Loading...</span>
        </div>
        <p className="mt-3">Loading stock data...</p>
      </div>
    );
  }

  return (
    <div className="container mt-4">
      <h1 className="text-center mb-4">Stock Market Dashboard</h1>

      <div className="row">
        {stocks.map((stock, index) => (
          <div key={index} className="col-md-4 mb-3">
            <div className="card">
              <div className="card-body">
                <h5 className="card-title">{stock.symbol}</h5>
                <p className="card-text">
                  <strong>${stock.price}</strong>
                  <span
                    className={
                      stock.change.startsWith("+")
                        ? "text-success"
                        : "text-danger"
                    }
                  >
                    {" "}
                    ({stock.change})
                  </span>
                </p>
              </div>
            </div>
          </div>
        ))}
      </div>

      {/* Refresh button to test lifecycle methods */}
      <div className="text-center mt-4">
        <button
          className="btn btn-primary"
          onClick={fetchStockData}
          disabled={loading}
        >
          {loading ? "Loading..." : "Refresh Data"}
        </button>
      </div>
    </div>
  );
}

export default Dashboard;
