import React from "react";
import ReactDOM from "react-dom/client";
import { ThirdwebProvider } from "@thirdweb-dev/react";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap-icons/font/bootstrap-icons.css";
import "./styles/welcome-screen.css";
import "./styles/index.css";
import "./styles/App.css";
import "./styles/spinners.css";
import "./styles/hero-content.css";
import "./styles/conditions.css";
import "./styles/card.css";
import "react-toastify/dist/ReactToastify.css";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <ThirdwebProvider activeChain="avalanche-fuji" autoConnect={true} >
  <React.StrictMode>
    <App />
  </React.StrictMode>
  </ThirdwebProvider>
  
);



// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();