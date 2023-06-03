import { HashRouter, Routes, Route } from 'react-router-dom';
import { lazy, Suspense } from 'react';
import Layout from './pages/Layout';

const Home = lazy(() => import('./pages/Home'));
const Mint = lazy(() => import('./pages/Mint'));
const Soon = lazy(() => import('./pages/Soon'));
const Contact = lazy(() => import('./pages/Contact'));
const PrivacyPolicy = lazy(() => import('./pages/PrivacyPolicy'));
const Terms = lazy(() => import('./pages/Terms'));
const NoPage = lazy(() => import('./pages/NoPage'));


export default function App() {
    return (
      <>
     <Suspense fallback={<div className="container">Loading...</div>}></Suspense>
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="jax-world-dapp/mint" element={<Mint />} />
            <Route path="jax-world-dapp/contact" element={<Contact />} />
            <Route path="jax-world-dapp/terms-of-use" element={<Terms />} />
            <Route path="jax-world-dapp/privacy-policy" element={<PrivacyPolicy />} />
            <Route path="jax-world-dapp/*" element={<NoPage />} />
          </Route>
        </Routes>
        </>
    );
  }