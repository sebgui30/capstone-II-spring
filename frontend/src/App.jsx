import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import Home from "./pages/Home";
import Login from "./pages/Login";
import HROnboarding from "./pages/HROnboarding";
import ManagerApproval from "./pages/ManagerApproval";
import ITProvisioning from "./pages/ITProvisioning";
import StatusTracking from "./pages/StatusTracking";

function App() {
  return (
    <Router>
      <Navbar />
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/home" element={<Home />} />
        <Route path="/hr" element={<HROnboarding />} />
        <Route path="/manager" element={<ManagerApproval />} />
        <Route path="/it" element={<ITProvisioning />} />
        <Route path="/status" element={<StatusTracking />} />
      </Routes>
    </Router>
  );
}

export default App;
