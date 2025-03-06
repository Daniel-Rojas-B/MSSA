import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import "./Dashboard.css";


function Dashboard() {
    const navigate = useNavigate();
    const [prediction, setPrediction] = useState("Select League and Teams ...");

    const [league, setLeague] = useState("");
    const [teamA, setTeamA] = useState('');
    const [teamB, setTeamB] = useState('');

    // Place bet State variables
    const [betType, setBetType] = useState('');
    const [betAmount, setBetAmount] = useState('');
    const [message, setMessage] = useState('');

    // Handle placing the bet
    const handlePlaceBet = () => {
        if (!betType || !betAmount || betAmount <= 0) {
            setMessage('Please select a valid bet type and amount.');
            return;
        }
        setMessage(`Bet placed! Type: ${betType}, Amount: $${betAmount}`);
    };
    
    const [matchDate, setMatchDate] = useState("");
    const [odds, setOdds] = useState({ home: 0, tie: 0, away: 0 });

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

    const handleFetchOdds = () => {
        if (league && teamA && teamB && matchDate) {
            // Simulating fetching odds from an API
            setOdds({
                home: (Math.random() * 3 + 1).toFixed(2),
                tie: (Math.random() * 3 + 2).toFixed(2),
                away: (Math.random() * 3 + 1).toFixed(2),
            });
        }
    };
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
                <h1>Bets Dashboard</h1>
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

                    {/*<input type="date" value={matchDate} onChange={(e) => setMatchDate(e.target.value)} />*/}

                    {/*<button onClick={handleFetchOdds} disabled={!teamA || !teamB || !matchDate}>Get Odds</button>*/}
                </div>

                {odds.home !== 0 && (
                    <div className="odds-container">
                        <div className="odds-box home">🏠 Home: {odds.home}</div>
                        <div className="odds-box tie">⚖️ Tie: {odds.tie}</div>
                        <div className="odds-box away">🚀 Away: {odds.away}</div>
                    </div>
                )}

                <h2>Match Brief and Odds</h2>
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
                    <input
                        type="number"
                        value={betAmount}
                        onChange={(e) => setBetAmount(e.target.value)}
                        min="1"
                        placeholder="Enter amount"
                    />

                    <button className="bet-button" onClick={handlePlaceBet} disabled={!betType || !betAmount || betAmount <= 0}>Place Bet</button>
                </div>

            </div>
        </div>    
    );
}

export default Dashboard;

