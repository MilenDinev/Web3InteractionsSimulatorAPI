import { ConnectButton } from './Helpers/renders/units/Connect';
import logo from '../images/logo.png';
export function Header() {

  return (
    
    
    <div className="container fonts">
    <header className="d-flex flex-wrap justify-content-center py-2 mb-3 custom">
    <a href="index" target="_blank" rel="noreferrer" className="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
      <img className="bi me-2" width="45" height="45" src={logo} alt="Jax World"></img>
      <span className="fs-2 fonts hover-effect"><b>Jax World</b></span>
    </a>

    <ul className="nav nav-pills header-nav-main text m-3">
      <li className="nav-item "><a href="index" target="_blank" rel="noreferrer" className="nav-link hover-effect menu-button" aria-current="page">Dashboard</a></li>
      <li className="nav-item"><a href="docs" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect menu-button">Docs</a></li>
      <li className="nav-item"><a href="mint" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect menu-button">Mint</a></li>
      <li className="nav-item"><a href="faq" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect menu-button">FAQ</a></li>
    </ul>
    <span className="nav-item m-2"><ConnectButton/></span>
  </header>
    </div>
  );
}

