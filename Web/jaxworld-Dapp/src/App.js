import Body from "./Components/Body";
import Footer from "./Components/Footer";
import Header from "./Components/Header";
import { useConnectionStatus } from "@thirdweb-dev/react";
import { WelcomeScreen } from "./Components/Helpers/renders/units/WelcomeScreen";
import { Hamster } from "./Components/Helpers/renders/customization/HamsterSpinner";
import { CanClaim } from "./Components/Helpers/liveData/CanClaim";
function App() {

  const connectionStatus = useConnectionStatus();
  const {isLoading} = CanClaim();

  return (  
    <>
    <div>
    <Header/>
    </div>
    { connectionStatus === 'disconnected' ? 
    <>
    <WelcomeScreen/>
    <Footer/>
    </>
     :
     isLoading || connectionStatus === 'connecting' ? <Hamster/> :
    <>
    <Body/>
    <Footer/>
    </>
    }
    
    </>
  );
}



export default App;
