import Body from "./Components/Body";
import Footer from "./Components/Footer";
import Header from "./Components/Header";
import { useConnectionStatus } from "@thirdweb-dev/react";
import { WelcomeScreen } from "./Components/Helpers/renders/units/WelcomeScreen";
function App() {

  const connectionStatus = useConnectionStatus();


  return (  
    <>
    <div>
    <Header/>
    </div>
    {connectionStatus === 'disconnected' ? 
    <>
    <WelcomeScreen/>
    <Footer/>
    </>
     :
    <>
    <Body/>
    <Footer/>
    </>
    }
    </>
  );
}



export default App;
