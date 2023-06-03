import { ConnectButton } from './Helpers/renders/units/Connect';
import logo from '../images/logo.png';
import brand from '../images/brand.png';
export function Header() {

  return (
    
    <>
    <div className="container fonts">
    <header className="d-flex flex-wrap justify-content-center py-2 mb-3 custom">
    <a href="/" data-toggle="tooltip" title="Home" rel="noreferrer" className="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-dark text-decoration-none">
      <img className="bi me-2" width="55" height="55" src={logo} alt="Jax World"></img>
      <img className="hover-effect bi me-2" width="150" height="80" src={brand} alt="Jax World"></img>
    </a>

    <ul className="nav nav-pills header-nav-main text m-3">

      <li className="nav-item" data-toggle="tooltip" title="Comming Soon"><a href="/dashboard" rel="noreferrer" className="nav-link hover-effect menu-button disabled " aria-current="page"style={{ background: ' rgba(204, 163, 130, 0.904)' }}>Dashboard</a> </li>

      <li className="nav-item" data-toggle="tooltip" title="Comming Soon"><a href="/saloon" rel="noreferrer" className="nav-link text-white hover-effect menu-button disabled" aria-current="page" style={{ background: ' rgba(204, 163, 130, 0.904)' }}>Saloon</a></li>
      <li className="nav-item" data-toggle="tooltip" title="Mint"><a href="/mint" rel="noreferrer" className="nav-link text-white hover-effect menu-button" aria-current="page">Mint</a></li>
      <li className="nav-item" data-toggle="tooltip" title="Docs"><a href="/docs" target="_blank" rel="noreferrer" className="nav-link text-white hover-effect menu-button" aria-current="page">Docs</a></li>
    </ul>
    <span className="nav-item m-2" data-toggle="tooltip" title="Connect"><ConnectButton/></span>
  </header>
    </div>
  </>
  );
}

