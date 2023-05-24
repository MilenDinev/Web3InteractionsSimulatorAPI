import { TotalSupply} from '../fragments/TotalSupply';
import { UnclaimedNFTSupply } from '../fragments/UnclaimdedSupply';
import { CurrentPhaseSupply } from '../fragments/CurrentPhaseSupply';
import { CurrentPhasePrice } from '../fragments/CurrentPhasePrice';
import { ClaimedNFTSupply } from '../fragments/TotalClaimedSupply';
import { ClaimStatusPerWallet } from '../fragments/ClaimStatus';

import './../../../../App.css';

export  function ContractData() {
return (
        <>       
          <div className="text-center form-control border-0 bg-secondary bg-gradient rounded-5 p-2 text-white bg-opacity-10 form-floating mb-3 Fonts">
            <TotalSupply/>
            <UnclaimedNFTSupply/>
            <CurrentPhaseSupply/>
            <ClaimedNFTSupply/>
            <ClaimStatusPerWallet/>
            <br></br>
            <CurrentPhasePrice/>
          </div>
        </>
  );
  }