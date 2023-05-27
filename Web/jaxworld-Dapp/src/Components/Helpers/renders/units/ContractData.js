import { TotalSupply} from "../fragments/TotalSupply";
import { UnclaimedNFTSupply } from "../fragments/UnclaimdedSupply";
import { CurrentPhaseSupply } from "../fragments/CurrentPhaseSupply";
import { CurrentPhasePrice } from "../fragments/CurrentPhasePrice";
import { ClaimedNFTSupply } from "../fragments/TotalClaimedSupply";
import { ClaimStatusPerWallet } from "../fragments/ClaimStatus";
export  function ContractData() {
return (
        <>       
          <div className="fonts">
          <TotalSupply/>
          <p className="fonts-style eligibility">
            <UnclaimedNFTSupply/>
            <CurrentPhaseSupply/>
            <ClaimedNFTSupply/></p>
            <ClaimStatusPerWallet/>
            <CurrentPhasePrice/>
          </div>
        </>
  );
  }