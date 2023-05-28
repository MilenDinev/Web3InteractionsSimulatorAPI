import { useConnectionStatus } from '@thirdweb-dev/react';
import { Hamster } from './Components/Helpers/renders/customization/HamsterSpinner';
import { Body } from './Components/Body';
import { Footer } from './Components/Footer';
import { Header } from './Components/Header';
import { WelcomeScreen } from './Components/Helpers/renders/units/WelcomeScreen';
import { useState, useEffect } from 'react';


function App() {
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    setLoading(true);
    setTimeout(() => {
      setLoading(false);
    }, 1000);
  }, []);

  const connectionStatus = useConnectionStatus();

  return loading ? (
    <div>
      <Hamster />{' '}
    </div>
  ) : (
    <>
      {connectionStatus === 'connected' ? (
        <>
          <Header />
          <Body />
          <Footer />
        </>
      ) : connectionStatus === 'disconnected' ? (
        <>
          <Header />
          <WelcomeScreen />
          <Footer />
        </>
      ) : (
        <>
          <Hamster />
        </>
      )}
    </>
  );
}

export default App;
