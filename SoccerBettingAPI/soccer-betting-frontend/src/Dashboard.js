import React, { useState } from "react";
import axios from "axios";
import "./Login.css"; // Import the CSS file

const Dashboard = () => {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const [message, setMessage] = useState("");

    const [isRegister, setIsRegister] = useState(false);

    const toggleForm = () => setIsRegister(!isRegister);

    const handleLogin = async () => {
        try {
            const response = await axios.post("http://localhost:5000/api/auth/login", {
                username,
                password,
            });

            localStorage.setItem("token", response.data.token);
            setMessage("Login successful!");
        } catch (error) {
            setMessage("Login failed.");
        }
    };

    return (
        <div className="container">
            <div className="header">
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
                    <text x="70" y="70" fontFamily="Arial, sans-serif" fontSize="14" fill="grey">
                        - Soccer Betting -
                    </text>
                </svg>
            </div>

            <div className="auth-box">
                {/* Login Box */}
                <div className="login-box">
                    <h3>Login</h3>
                    <form>
                        <div className="input-group">
                            <i className="fas fa-user"></i>
                            <input type="text" placeholder="User name" required />
                        </div>
                        <div className="input-group">
                            <i className="fas fa-lock"></i>
                            <input type="password" placeholder="Password" required />
                        </div>
                        <button type="submit" className="login-btn">LOGIN</button>
                    </form>
                </div>

                {/* Registration Box */}
                <div className="register-box">
                    <h3>Register</h3>
                    <form>
                        <div className="input-group">
                            <i className="fas fa-user"></i>
                            <input type="text" placeholder="Full Name" required />
                        </div>
                        <div className="input-group">
                            <i className="fas fa-envelope"></i>
                            <input type="email" placeholder="Email" required />
                        </div>
                        <div className="input-group">
                            <i className="fas fa-lock"></i>
                            <input type="password" placeholder="Password" required />
                        </div>
                        <button type="submit" className="register-btn">REGISTER</button>
                    </form>
                </div>
            </div>
        </div>

    );
};

export default Dashboard;
