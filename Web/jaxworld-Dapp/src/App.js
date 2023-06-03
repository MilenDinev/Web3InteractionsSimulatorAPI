import { BrowserRouter, Routes, Route } from "react-router-dom";
import { lazy, Suspense } from 'react';
import Layout from "./pages/Layout";
import { PrivacyPolicy } from "./pages/PrivacyPolicy";
import {Terms} from "./pages/Terms";
import { Contact } from "./pages/Contact";

const Home = lazy(() => import('./pages/Home'));
const Mint = lazy(() => import('./pages/Mint'));
const NoPage = lazy(() => import('./pages/NoPage'));


export default function App() {
    return (
      <BrowserRouter>
             <Suspense fallback={<div className="container">Loading...</div>}></Suspense>
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="mint" element={<Mint />} />
            <Route path="contact" element={<Contact />} />
            <Route path="terms-of-use" element={<Terms />} />
            <Route path="privacy-policy" element={<PrivacyPolicy />} />
            <Route path="*" element={<NoPage />} />
          </Route>
        </Routes>
      </BrowserRouter>
    );
  }