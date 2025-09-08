import React from "react";
import { Line } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
} from "chart.js";

// Register the components we need
ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend
);

function StockChart({ stockData }) {
  // Sample data for the chart
  const data = {
    labels: ["9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM"],
    datasets: [
      {
        label: "AAPL Stock Price",
        data: [148, 150, 149, 152, 151, 150],
        borderColor: "rgb(75, 192, 192)",
        backgroundColor: "rgba(75, 192, 192, 0.2)",
        tension: 0.1,
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: {
        position: "top",
      },
      title: {
        display: true,
        text: "Stock Price Chart",
      },
    },
  };

  return (
    <div className="card">
      <div className="card-body">
        <Line data={data} options={options} />
      </div>
    </div>
  );
}

export default StockChart;
