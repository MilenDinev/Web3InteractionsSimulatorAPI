import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';

export function Footer() {
  return (

    <div id="footer" className="container">
    <footer className="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
      <ul className="nav col-md-4 justify-content-start">
        <li className="ms-2"><a className="text-muted" target="_blank" rel="noreferrer" href="https://discord.com/invite/dPNE6fK4S4"><i className="bi bi-discord" style={{ fontSize: 20 }}></i></a></li>
        <li className="ms-2"><a className="text-muted" target="_blank" rel="noreferrer" href="https://twitter.com/jaxworld_"><i className="bi bi-twitter" style={{ fontSize: 20 }}></i></a></li>
        <li className="ms-2"><a className="text-muted" target="_blank" rel="noreferrer" href="https://medium.com/@jaxminersworld"><i className="bi bi-medium" style={{ fontSize: 20 }}></i></a></li>
      </ul>
      <a href="index" target="_blank" rel="noreferrer" className="col-md-4 d-flex justify-content-center text-decoration-none">
        <p className="col-md-4 mb-0 text-muted">&copy; 2023 Jax World</p>
      </a>
  
      <ul className="nav col-md-4 justify-content-end">
        <li className="nav-item"><a href="index" target="_blank" rel="noreferrer" className="nav-link px-2 text-muted hover-effect">Home</a></li>
        <li className="nav-item"><a href="faq" target="_blank" rel="noreferrer" className="nav-link px-2 text-muted hover-effect">FAQs</a></li>
        <li className="nav-item"><a href="term-of-use" target="_blank" rel="noreferrer" className="nav-link px-2 text-muted hover-effect">Term of Use</a></li>
        <li className="nav-item"><a href="privacy-policy" target="_blank" rel="noreferrer" className="nav-link px-2 text-muted hover-effect">Privacy policy</a></li>
      </ul>
    </footer>
    </div>
  );
}
