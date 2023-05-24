import Body from "./Components/Body";
import Footer from "./Components/Footer";
import Header from "./Components/Header";
import { useConnectionStatus } from "@thirdweb-dev/react";
function App() {

  const connectionStatus = useConnectionStatus();


  return (  
    <>
    <div>
    <Header/>
    </div>
    {connectionStatus === 'disconnected' ? 'You need to connect...' :
    <>
    <Body/>
    <Footer/>
    </>
    }
    </>
  );
}



export default App;
