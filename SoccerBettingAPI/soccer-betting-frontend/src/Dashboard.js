import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

function Dashboard() {
    const navigate = useNavigate();
    const [prediction, setPrediction] = useState("Loading prediction...");

    const handleLogout = () => {
        localStorage.removeItem("token"); // Remove JWT token
        navigate("/"); // Redirect to Login
    };

    useEffect(() => {
        const homeTeam = "Liverpool";
        const awayTeam = "Manchester City";
        const backendUrl = "http://localhost:5180";
        const token = localStorage.getItem("token"); // Retrieve JWT

        async function fetchPrediction() {
            try {
                const response = await fetch(`${backendUrl}/api/Prediction/match?homeTeam=${homeTeam}&awayTeam=${awayTeam}`, {
                    method: "GET",
                    headers: {
                        "Authorization": `Bearer ${token}`,  // Send JWT token
                        "Content-Type": "application/json",
                    },
                    credentials: "include", // Ensure credentials are sent
                });

                if (!response.ok) {
                    throw new Error(`HTTP error! Status: ${response.status}`);
                }

                const data = await response.json();
                setPrediction(`Prediction: ${data.prediction}`);
            } catch (error) {
                console.error("Error fetching prediction:", error);
                setPrediction("Failed to load prediction.");
            }
        }

        fetchPrediction();
    }, []); // Run once when component mounts

    return (
        <div className="container">
            {/* Fixed Header */}
            <div
                className="header"
                style={{
                    display: "flex",
                    justifyContent: "center",
                    alignItems: "center",
                    position: "fixed",
                    top: "0",
                    left: "0",
                    width: "100%",
                    backgroundColor: "black",
                    padding: "15px",
                    boxShadow: "0px 4px 6px rgba(0, 0, 0, 0.3)",
                    zIndex: "1000"
                }}
            >
                {/* SVG Logo */}
                <svg width="300" height="100" viewBox="0 0 300 100" xmlns="http://www.w3.org/2000/svg">
                    <defs>
                        <linearGradient id="greenGradient" x1="0%" y1="0%" x2="100%" y2="0%">
                            <stop offset="0%" style={{ stopColor: "#28a745", stopOpacity: 1 }} />
                            <stop offset="100%" style={{ stopColor: "#218838", stopOpacity: 1 }} />
                        </linearGradient>
                    </defs>

                    {/* Soccer Ball */}
                    <circle cx="40" cy="50" r="20" fill="black" stroke="white" strokeWidth="3" />
                    <polygon points="40,30 30,40 35,50 45,50 50,40" fill="white" />
                    <polygon points="40,70 30,60 35,50 45,50 50,60" fill="white" />

                    {/* Text */}
                    <text x="70" y="45" fontFamily="Arial, sans-serif" fontSize="20" fill="url(#greenGradient)" fontWeight="bold">
                        Bet & Chill
                    </text>
                    <text x="70" y="70" fontFamily="Arial, sans-serif" fontSize="14" fill="lightgrey">
                        - Soccer Betting -
                    </text>
                </svg>

                {/* Logout Button */}
                <button
                    onClick={handleLogout}
                    style={{
                        position: "absolute",
                        top: "20px",
                        right: "50px",
                        backgroundColor: "#dc3545",
                        color: "white",
                        border: "none",
                        padding: "10px 15px",
                        fontSize: "16px",
                        cursor: "pointer",
                        borderRadius: "5px"
                    }}
                >
                    Logout
                </button>
            </div>

            {/* Page Content */}
            <div style={{
                display: "flex",
                justifyContent: "center",
                alignItems: "center",
                minHeight: "calc(100vh - 100px)", // Ensures full viewport height minus header
                marginTop: "100px", // Adjusts space under the fixed header
                padding: "20px"
            }}>
                <div style={{
                    width: "80%", // Wide responsive box
                    maxWidth: "900px", // Prevents excessive width on larger screens
                    padding: "30px",
                    backgroundColor: "white",
                    borderRadius: "12px",
                    boxShadow: "0px 4px 10px rgba(0, 0, 0, 0.1)", // Soft shadow for depth
                    textAlign: "center"
                }}>
                    <h1>Welcome to Dashboard</h1>
                    <div>
                        <h2>Match Prediction</h2>
                        <p>{prediction}</p>
                    </div>
                </div>
            </div>



        </div>
    );
}

export default Dashboard;

