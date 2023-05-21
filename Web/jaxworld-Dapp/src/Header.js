import logo from './images/logo.png';
import './styles/custom.css';
import { ConnectButton } from './Components/Connect';
import './App.css';

function Header() {
  return (
    
    <div className="fs-5 App Fonts">
    <header className="d-flex flex-wrap justify-content-center py-2 mb-3 border-bottom">
    <a href="index" target="_blank" rel="noreferrer" className="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
      <img className="bi me-2" width="45" height="45" src={logo} alt="Jax World"></img>
      <span className="fs-2 Fonts hover-effect"><b>Jax World</b></span>
    </a>

    <ul className="nav nav-pills">
      <li className="nav-item"><a href="index" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect" aria-current="page">Home</a></li>
      <li className="nav-item"><a href="#" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect">Features</a></li>
      <li className="nav-item"><a href="#" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect">Pricing</a></li>
      <li className="nav-item"><a href="faq" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect">FAQs</a></li>
    </ul>
    <span className="nav-item"><ConnectButton/></span>
  </header>

  
    </div>
  );
}

export default Header;
