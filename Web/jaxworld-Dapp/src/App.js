import { Routes, Route } from 'react-router-dom';
import { HashRouter } from 'react-router-dom';
import { lazy, Suspense } from 'react';
import { ThirdwebProvider } from '@thirdweb-dev/react';
import { Hamster } from './Components/renders/customization/HamsterSpinner';
import Layout from './pages/Layout';

const Mint = lazy(() => import('./pages/Mint'));
const Home = lazy(() => import('./pages/Home'));
const PrivacyPolicy = lazy(() => import('./pages/PrivacyPolicy'));
const Terms = lazy(() => import('./pages/Terms'));
const Soon = lazy(() => import('./pages/Soon'));
const Contact = lazy(() => import('./pages/Contact'));
const NoPage = lazy(() => import('./pages/NoPage'));


export default function App() {
    return (
<ThirdwebProvider activeChain="avalanche" autoConnect={true} >
  <HashRouter>
     <Suspense fallback={    <div><Hamster />{' '}</div>}>
        <Routes>
            <Route path="/" element={<Layout title = "Jax World - Blockhain Gaming Platform" />}>
            <Route index element={<Home title = "Jax World - Blockhain Gaming Platform"/>} />
            <Route path="/mint" element={<Mint />} />
            <Route path="/contact" element={<Contact title = "Jax World - Contact Us"/>} />
            <Route path="/terms-of-use" element={<Terms title = "Jax World - Terms Of Use" />} />
            <Route path="/privacy-policy" element={<PrivacyPolicy title = "Jax World - Privacy Policy"/>} />
            <Route path="/*" element={<NoPage />} />
          </Route>
        </Routes>
        </Suspense>
          </HashRouter>
          </ThirdwebProvider>
    );
  }




  //avalanche-fuji