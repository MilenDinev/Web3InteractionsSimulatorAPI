import { useConnectionStatus } from '@thirdweb-dev/react';
import { Body } from '../mint-event-src/main/Body';
import { WelcomeScreen } from '../mint-event-src/components/renders/units/WelcomeScreen';
import { Hamster } from '../mint-event-src/components/renders/customization/HamsterSpinner';
import { useState, useEffect } from 'react';


export default function Mint() {
  const [loading, setLoading] = useState(false);

  document.title = 'Jax World - Mint';

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
          <Body />
        </>
      ) : connectionStatus === 'disconnected' ? (
        <>
          <WelcomeScreen />
        </>
      ) : (
        <>
          <Hamster />
        </>
      )}
    </>
  );
}

