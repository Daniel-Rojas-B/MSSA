import React from "react";
import { useNavigate } from "react-router-dom";


function Dashboard() {
    const navigate = useNavigate();

    const handleLogout = () => {
        localStorage.removeItem("token"); // Remove JWT token
        navigate("/"); // Redirect to Login
    };

    return (
        <div className="container">
            {/* Fixed Header at the Top with Black Background */}
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

                {/* Logout Button - Positioned Absolutely in Top-Right */}
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

            {/* Page Content with Margin to Avoid Overlap */}
            <div style={{ marginTop: "120px", padding: "20px" }}>
                <h1>Welcome to Dashboard</h1>
            </div>
        </div>

    );
}

export default Dashboard;
