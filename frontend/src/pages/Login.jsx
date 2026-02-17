import { useState } from "react";
import { useNavigate } from "react-router-dom";
import "./Login.css";

function Login() {
  const navigate = useNavigate();

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [role, setRole] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();

    if (!firstName || !lastName || !role) {
      alert("Please fill out all fields");
      return;
    }

    // Route based on role
    if (role === "hr") navigate("/hr");
    if (role === "manager") navigate("/manager");
    if (role === "it") navigate("/it");
  };

  return (
    <div className="login-page">
      <h2 className="login-header">Login</h2>

    <div className="login-container">
      <form onSubmit={handleSubmit}>
        <label>
          First Name
          <input
            type="text"
            value={firstName}
            onChange={(e) => setFirstName(e.target.value)}
          />
        </label>

        <label>
          Last Name
          <input
            type="text"
            value={lastName}
            onChange={(e) => setLastName(e.target.value)}
          />
        </label>

        <fieldset className="radio-group">
          <legend>Select a Role</legend>

          <label className="radio-option">
            <input type="radio" name="role" value="hr" />
            HR
          </label>

          <label className="radio-option">
            <input type="radio" name="role" value="manager" />
            Manager
          </label>

          <label className="radio-option">
            <input type="radio" name="role" value="it" />
            IT
          </label>
        </fieldset>

        <button type="submit">Submit</button>
      </form>
    </div>
  </div>
  );
}

export default Login;