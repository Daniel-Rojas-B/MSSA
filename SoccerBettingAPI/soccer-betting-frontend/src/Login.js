import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "./Login.css"; // Import the CSS file

function Login() {
    // Login State
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");
    const navigate = useNavigate(); // For navigation

    // Register State
    const [registerData, setRegisterData] = useState({
        username: "",
        password: "",
        email: "",
    });

    const [registerError, setRegisterError] = useState("");
    const [registerSuccess, setRegisterSuccess] = useState("");

    // Handle Login
    const handleLogin = async (e) => {
        e.preventDefault();
        setError(""); // Clear any previous errors

        try {
            const response = await fetch("https://localhost:7020/api/auth/login", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({
                    username,
                    password: password
                }),
            });

            if (!response.ok) {
                const errorData = await response.json();
                throw new Error("Invalid login credentials");
            }

            const data = await response.json();
            localStorage.setItem("token", data.token); // Store JWT token
            navigate("/dashboard"); // Redirect to Dashboard
        } catch (err) {
            setError(err.message);
        }
    };

    // Handle Register Input Change
    const handleRegisterChange = (e) => {
        setRegisterData({ ...registerData, [e.target.name]: e.target.value });
    };

    // Handle Register Submission
    const handleRegister = async (e) => {
        e.preventDefault();
        setRegisterError("");
        setRegisterSuccess("");

        const userData = {
            username: registerData.username,
            passwordHash: registerData.password,  // Fixed key
            email: registerData.email,
            walletBalance: 0.0, // Default value
            bets: [] // Default value
        };

        console.log("Sending data:", JSON.stringify(userData, null, 2));

        try {
            
            const response = await fetch("https://localhost:7020/api/user/register", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(userData),
            });

            if (!response.ok) {
                const errorData = await response.json();
                throw new Error(errorData.message || "Registration failed");
            }

            setRegisterSuccess("User registered successfully!");
            setRegisterData({ username: "", password: "", email: "" });

            navigate("/dashboard"); // Redirect to Dashboard

        } catch (err) {
            setRegisterError(err.message);
        }
    };

    return (
        <div className="container">
            {/* Header */}
            <div className="header">
                <div className="logo-container">
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

                
            </div>

            <div className="auth-box">
                {/* Login Box */}
                <div className="login-box">
                    <h3>Login</h3>
                    {error && <p style={{ color: "red" }}>{error}</p>}
                    <form onSubmit={handleLogin}>
                        <div className="input-group">
                            <i className="fas fa-user"></i>
                            <input type="text" placeholder="Username" value={username} onChange={(e) => setUsername(e.target.value)} />
                        </div>
                        <div className="input-group">
                            <i className="fas fa-lock"></i>
                            <input type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)} />
                        </div>
                        <button type="submit" className="login-btn">LOGIN</button>
                    </form>
                </div>

                {/* Registration Box */}
                <div className="register-box">
                    <h3>Register</h3>
                    {registerError && <p style={{ color: "red" }}>{registerError}</p>}
                    {registerSuccess && <p style={{ color: "green" }}>{registerSuccess}</p>}
                    <form onSubmit={handleRegister}>
                        <div className="input-group">
                            <i className="fas fa-user"></i>
                            <input
                                type="text"
                                name="username"
                                placeholder="Username"
                                value={registerData.username}
                                onChange={handleRegisterChange}
                                required
                            />
                        </div>
                        <div className="input-group">
                            <i className="fas fa-lock"></i>
                            <input
                                type="password"
                                name="password"
                                placeholder="Password"
                                value={registerData.password}
                                onChange={handleRegisterChange}
                                required
                            />
                        </div>
                        <div className="input-group">
                            <i className="fas fa-envelope"></i>
                            <input
                                type="email"
                                name="email"
                                placeholder="Email"
                                value={registerData.email}
                                onChange={handleRegisterChange}
                                required
                            />
                        </div>
                        <button type="submit" className="register-btn">REGISTER</button>
                    </form>
                </div>
            </div>
        </div>
    );
}

export default Login;
