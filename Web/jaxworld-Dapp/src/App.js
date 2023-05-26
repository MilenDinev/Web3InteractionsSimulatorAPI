import { useConnectionStatus } from '@thirdweb-dev/react';
import { Hamster } from './Components/Helpers/renders/customization/HamsterSpinner';
import { Body } from './Components/Body';
import { Footer } from './Components/Footer';
import { Header } from './Components/Header';
import { WelcomeScreen } from './Components/Helpers/renders/units/WelcomeScreen';
function App() {
  const connectionStatus = useConnectionStatus();

  return (
    <>
      <Header />
      {connectionStatus === 'disconnected' ? (
        <>
          <WelcomeScreen />
          <Footer />
        </>
      ) : connectionStatus === 'uknown' || connectionStatus === 'connecting' ? (
        <Hamster />
      ) : connectionStatus === 'connected' ? (
        <>
          <Body />
          <Footer />
        </>
      ) : (
        <>
          <WelcomeScreen />
          <Footer />
        </>
      )}
    </>
  );
}

export default App;
