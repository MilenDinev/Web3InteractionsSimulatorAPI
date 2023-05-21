import logo from './images/logo.png';
import './styles/custom.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { ConnectWallet } from "@thirdweb-dev/react";

function App() {
  return (
    
    <div className="App">
    <header className="d-flex flex-wrap justify-content-center py-3 mb-4 border-bottom">
    <a href="#Home" className="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
      <img className="bi me-2" width="45" height="45" src={logo} alt="Jax World"></img>
      <span className="fs-3">Jax World</span>
    </a>

    <ul className="nav nav-pills">
      <li className="nav-item"><a href="#" className="nav-link active" aria-current="page">Home</a></li>
      <li className="nav-item"><a href="#" className="nav-link">Features</a></li>
      <li className="nav-item"><a href="#" className="nav-link">Pricing</a></li>
      <li className="nav-item"><a href="#" className="nav-link">FAQs</a></li>
      <li className="nav-item"><a href="#" className="nav-link"><ConnectButton/></a></li>
    </ul>
  </header>

  
    </div>
  );
}

function ConnectButton() {
  return (
    <ConnectWallet
      theme="light"
      auth={{
        loginOptional: false,
      }}
    />
  );
}

export default App;
