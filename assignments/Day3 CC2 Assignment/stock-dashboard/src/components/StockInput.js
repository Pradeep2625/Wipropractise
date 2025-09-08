import React, { useState, useRef } from "react";

function StockInput({ onAddStock }) {
  // CONTROLLED COMPONENT - React manages this input
  const [controlledSymbol, setControlledSymbol] = useState("");

  // UNCONTROLLED COMPONENT - DOM manages this input
  const uncontrolledRef = useRef(null);
  const [searchHistory, setSearchHistory] = useState([]);

  const handleControlledSubmit = (e) => {
    e.preventDefault();
    if (controlledSymbol.trim()) {
      onAddStock(controlledSymbol.toUpperCase());
      setControlledSymbol(""); // Clear the input
    }
  };

  const handleUncontrolledSubmit = (e) => {
    e.preventDefault();
    const symbol = uncontrolledRef.current.value;
    if (symbol.trim()) {
      // Add to search history
      setSearchHistory((prev) => [...prev, symbol.toUpperCase()]);
      uncontrolledRef.current.value = ""; // Clear the input
    }
  };

  return (
    <div className="row mb-4">
      {/* CONTROLLED COMPONENT */}
      <div className="col-md-6">
        <div className="card">
          <div className="card-body">
            <h5 className="card-title">Add New Stock (Controlled)</h5>
            <form onSubmit={handleControlledSubmit}>
              <div className="mb-3">
                <input
                  type="text"
                  className="form-control"
                  value={controlledSymbol}
                  onChange={(e) => setControlledSymbol(e.target.value)}
                  placeholder="Enter stock symbol (e.g., AAPL)"
                />
              </div>
              <button type="submit" className="btn btn-primary">
                Add Stock
              </button>
            </form>
          </div>
        </div>
      </div>

      {/* UNCONTROLLED COMPONENT */}
      <div className="col-md-6">
        <div className="card">
          <div className="card-body">
            <h5 className="card-title">Search History (Uncontrolled)</h5>
            <form onSubmit={handleUncontrolledSubmit}>
              <div className="mb-3">
                <input
                  type="text"
                  className="form-control"
                  ref={uncontrolledRef}
                  placeholder="Enter symbol to save to history"
                />
              </div>
              <button type="submit" className="btn btn-secondary">
                Save to History
              </button>
            </form>

            {/* Display search history */}
            <div className="mt-3">
              <h6>Recent Searches:</h6>
              {searchHistory.map((symbol, index) => (
                <span key={index} className="badge bg-secondary me-1">
                  {symbol}
                </span>
              ))}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default StockInput;
