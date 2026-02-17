import { Link } from "react-router-dom";
import "./Navbar.css";
import userIcon from "../assets/user-icon.png";

export default function Navbar() {
  return (
    <nav className="navbar">
      <div className="nav-left" />

      <div className="nav-center">
        <Link to="/home" className="nav-link">
          Home
        </Link>
      </div>

      <div className="nav-right">
        <img src={userIcon} alt="User" className="user-icon"/>
      </div>
    </nav>
  );
}