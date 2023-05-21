import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Header from './Header';
import Body from './Body';
import Footer from './Footer';
import reportWebVitals from './reportWebVitals';
import 'bootstrap/dist/css/bootstrap.min.css';
import { ThirdwebProvider } from '@thirdweb-dev/react';

// const root = ReactDOM.createRoot(document.getElementById('root'));
// root.render(
//   <ThirdwebProvider activeChain="avalanche-fuji" autoConnect={true} >
//   <React.StrictMode>
//     <App />
//   </React.StrictMode>
//   </ThirdwebProvider>
// );



const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <ThirdwebProvider activeChain="avalanche-fuji" autoConnect={true} >
  <React.StrictMode>
    <Header />
  </React.StrictMode>
  </ThirdwebProvider>
);


const hero = ReactDOM.createRoot(document.getElementById('hero'));
hero.render(
  <ThirdwebProvider activeChain="avalanche-fuji" autoConnect={false} >
  <React.StrictMode>
    <Body />
  </React.StrictMode>
  </ThirdwebProvider>
);

const footer = ReactDOM.createRoot(document.getElementById('footer'));
footer.render(
  <React.StrictMode>
    <Footer />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();