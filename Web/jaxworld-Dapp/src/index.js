import { ThirdwebProvider } from '@thirdweb-dev/react';
import React from 'react';
import ReactDOM from "react-dom/client";
import { hydrate, render } from "react-dom";
import App from "./App";
import reportWebVitals from './reportWebVitals';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import 'react-toastify/dist/ReactToastify.css';
import './styles/welcome-screen.css';
import './styles/index.css';
import './styles/App.css';
import './styles/spinners.css';
import './styles/hero-content.css';
import './styles/conditions.css';
import './styles/card.css';
import './styles/navigation.css';
import './styles/data.css';
import './styles/policies.css';
import './styles/contact-form.css';
import { HashRouter } from "react-router-dom";

const rootElement = document.getElementById("root");
if (rootElement.hasChildNodes()) {
  hydrate(<ThirdwebProvider activeChain="avalanche" autoConnect={true} >
  <React.StrictMode>
  <HashRouter>
    <App />
  </HashRouter>
  </React.StrictMode>
  </ThirdwebProvider>, rootElement);
} else {
  render( 
  <ThirdwebProvider activeChain="avalanche" autoConnect={true} >
  <React.StrictMode>
  <HashRouter>
    <App />
  </HashRouter>
  </React.StrictMode>
  </ThirdwebProvider>, rootElement);
}



// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();