import { Routes, Route } from 'react-router-dom';
import { lazy, Suspense } from 'react';
import { Hamster } from "./Components/Helpers/renders/customization/HamsterSpinner";
import Layout from './pages/Layout';
import Home from './pages/Home';
import PrivacyPolicy from './pages/PrivacyPolicy';
import Terms from './pages/Terms';
import { ThirdwebProvider } from '@thirdweb-dev/react';
import { HashRouter } from "react-router-dom";

const Mint = lazy(() => import('./pages/Mint'));
const Soon = lazy(() => import('./pages/Soon'));
const Contact = lazy(() => import('./pages/Contact'));
const NoPage = lazy(() => import('./pages/NoPage'));


export default function App() {
    return (
<ThirdwebProvider activeChain="avalanche" autoConnect={true} >
  <HashRouter>
     <Suspense fallback={    <div><Hamster />{' '}</div>}>
        <Routes>
            <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="/mint" element={<Mint />} />
            <Route path="/contact" element={<Contact />} />
            <Route path="/terms-of-use" element={<Terms />} />
            <Route path="/privacy-policy" element={<PrivacyPolicy />} />
            <Route path="/*" element={<NoPage />} />
          </Route>
        </Routes>
        </Suspense>
          </HashRouter>
          </ThirdwebProvider>
    );
  }