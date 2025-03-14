import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import "./Dashboard.css";


function Dashboard() {
    const navigate = useNavigate();
    const [prediction, setPrediction] = useState("Select League and Teams ...");
    const [league, setLeague] = useState("");
    const [teamA, setTeamA] = useState('');
    const [teamB, setTeamB] = useState('');    
    const [betType, setBetType] = useState('');
    const [betAmount, setBetAmount] = useState('');
    const [message, setMessage] = useState('');
    const [bets, setBets] = useState([]);
    const [editingIndex, setEditingIndex] = useState(null);

    const handlePlaceBet = () => {
        if (!betType || !betAmount || betAmount <= 0) {
            setMessage('Please select a valid bet type and amount.');
            return;
        }

        const newBet = { league, teamA, teamB, betType, betAmount };

        if (editingIndex !== null) {
            const updatedBets = [...bets];
            updatedBets[editingIndex] = newBet;
            setBets(updatedBets);
            setEditingIndex(null);
        } else {
            setBets([...bets, newBet]);
        }

        setMessage(`Bet placed! Type: ${betType}, Amount: $${betAmount}`);
        setBetType('');
        setBetAmount('');
    };

    const handleEditBet = (index) => {
        const bet = bets[index];
        setLeague(bet.league);
        setTeamA(bet.teamA);
        setTeamB(bet.teamB);
        setBetType(bet.betType);
        setBetAmount(bet.betAmount);
        setEditingIndex(index);
    };

    const handleDeleteBet = (index) => {
        setBets(bets.filter((_, i) => i !== index));
    };

    const leagues = {
        "Premier": [
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Brentford",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Fulham",
            "Liverpool",
            "Luton Town",
            "Manchester City",
            "Manchester United",
            "Newcastle United",
            "Nottingham Forest",
            "Sheffield United",
            "Tottenham Hotspur",
            "West Ham United",
            "Wolverhampton Wanderers"
        ],
        "La Liga": [
            "Alaves",
            "Athletic Bilbao",
            "Atletico Madrid",
            "Barcelona",
            "Real Madrid",
            "Celta Vigo",
            "Cadiz",
            "Getafe",
            "Granada",
            "Mallorca",
            "Osasuna",
            "Rayo Vallecano",
            "Real Betis",
            "Real Sociedad",
            "Sevilla",
            "Valencia",
            "Villarreal"
        ],
        "Serie A": [
            "Atalanta",
            "Bologna",
            "Cagliari",
            "Empoli",
            "Fiorentina",
            "Genoa",
            "Inter Milan",
            "Juventus",
            "Lazio",
            "Lecce",
            "Milan",
            "Monza",
            "Napoli",
            "Roma",
            "Salernitana",
            "Sampdoria",
            "Sassuolo",
            "Spezia",
            "Torino",
            "Udinese"
        ],
        "Bundesliga": [
            "Bayer Leverkusen",
            "Bayern Munich",
            "Bochum",
            "Borussia Dortmund",
            "Cologne",
            "Eintracht Frankfurt",
            "Freiburg",
            "Hoffenheim",
            "Mainz",
            "RB Leipzig",
            "Wolfsburg",
            "Werder Bremen",
            "Union Berlin",
            "VfB Stuttgart"
        ],
        "Ligue 1": [
            "Angers SCO",
            "Auxerre",
            "Brest",
            "Lens",
            "Lille",
            "Lyon",
            "Marseille",
            "Monaco",
            "Montpellier",
            "Nice",
            "Paris Saint-Germain",
            "Reims",
            "Rennes",
            "Strasbourg",
            "Toulouse",
            "Clermont",
            "Lorient",
            "Nantes"],
    };

    const backendUrl = "http://localhost:5180";
    const token = localStorage.getItem("token"); // Retrieve JWT

    
    const handleLogout = () => {
        localStorage.removeItem("token"); // Remove JWT token
        navigate("/"); // Redirect to Login
    };

    useEffect(() => {
        if (teamA && teamB) {
                       

            async function fetchPrediction() {
                try {
                    const response = await fetch(`${backendUrl}/api/Prediction/match?homeTeam=${teamA}&awayTeam=${teamB}`, {
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
        }
    }, [teamA, teamB]); // Only runs when teamA or teamB change

    
    
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

                <button className="logout-btn" onClick={handleLogout}>Logout</button>
            </div>

           

            {/* Dashboard */}
            <div className="dashboard">
                <h1>Dashboard</h1>
                <div className="selection">
                    <label>League:</label>
                    <select value={league} onChange={(e) => { setLeague(e.target.value); setTeamA(""); setTeamB(""); }}>
                        <option value="">Select League</option>
                        {Object.keys(leagues).map((lg) => (
                            <option key={lg} value={lg}>{lg}</option>
                        ))}
                    </select>

                    <label>Home Team:</label>
                    <select value={teamA} onChange={(e) => { setTeamA(e.target.value); setTeamB(""); }} disabled={!league}>
                        <option value="">Select Team A</option>
                        {league && leagues[league].map((team) => (
                            <option key={team} value={team}>{team}</option>
                        ))}
                    </select>

                    <label>Away Team:</label>
                    <select value={teamB} onChange={(e) => setTeamB(e.target.value)} disabled={!league || !teamA}>
                        <option value="">Select Team B</option>
                        {league && leagues[league].filter((team) => team !== teamA).map((team) => (
                            <option key={team} value={team}>{team}</option>
                        ))}
                    </select>

                    
                </div>
                

                <h2>Brief and Odds</h2>
                <p style={{ color: 'red' }}>{prediction}</p>

                <div className="betting-selection">
                    <label>Type of Bet:</label>
                    <select value={betType} onChange={(e) => setBetType(e.target.value)}>
                        <option value="">Select Bet Type</option>
                        <option value="home">Home</option>
                        <option value="tie">Tie</option>
                        <option value="away">Away</option>
                    </select>

                    <label>Bet Amount:</label>
                    <input className="responsive-input" type="number" value={betAmount} onChange={(e) => setBetAmount(e.target.value)} min="1" />
                    <button className="bet-button"  onClick={handlePlaceBet}>{editingIndex !== null ? "Update Bet" : "Place Bet"}</button>                    
                </div>
                <p style={{ color: 'green' }}>{message}</p>
                <table className="bet-table">
                    <thead>
                        <tr>
                            <th>League</th>
                            <th>Home Team</th>
                            <th>Away Team</th>
                            <th>Bet Type</th>
                            <th>Amount</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {bets.map((bet, index) => (
                            <tr key={index}>
                                <td>{bet.league}</td>
                                <td>{bet.teamA}</td>
                                <td>{bet.teamB}</td>
                                <td>{bet.betType}</td>
                                <td>${bet.betAmount}</td>
                                <td>
                                    <button className="edit-button" onClick={() => handleEditBet(index)}>Edit</button>
                                    <button className="delete-button" onClick={() => handleDeleteBet(index)}>Delete</button>
                                </td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        </div>    
    );
}

export default Dashboard;

