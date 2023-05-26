import { TotalSupply} from "../fragments/TotalSupply";
import { UnclaimedNFTSupply } from "../fragments/UnclaimdedSupply";
import { CurrentPhaseSupply } from "../fragments/CurrentPhaseSupply";
import { CurrentPhasePrice } from "../fragments/CurrentPhasePrice";
import { ClaimedNFTSupply } from "../fragments/TotalClaimedSupply";
import { ClaimStatusPerWallet } from "../fragments/ClaimStatus";

export  function ContractData() {
return (
        <>       
          <div className="text-center form-control border-0 bg-secondary bg-gradient rounded-5 p-1 bg-opacity-10 form-floating mb-2 fonts">
          <p className="fonts-style eligibility"><TotalSupply/>
            <UnclaimedNFTSupply/>
            <CurrentPhaseSupply/>
            <ClaimedNFTSupply/></p>
            <ClaimStatusPerWallet/>
            <CurrentPhasePrice/>
          </div>
        </>
  );
  }