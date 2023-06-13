import { TotalSupply } from './TotalSupply';
import { UnclaimedNFTSupply } from './UnclaimdedSupply';
import { CurrentPhaseSupply } from './CurrentPhaseSupply';
import { CurrentPhaseMinted } from './CurrentPhaseMinted';
import { ClaimedNFTSupply } from './TotalClaimedSupply';
import { CurrentPhasePrice } from './CurrentPhasePrice';
import { ClaimStatusPerWallet } from './ClaimStatus';
import { Claim } from '../units/Claim';

export function LiveData() {
  return (
    <>
      <div className="data">
        <div className="data-style total-supply">
          <TotalSupply />
        </div>

        <div className="data-style eligibility ">
          <div className="data-style common-data">
            <UnclaimedNFTSupply />
          </div>

          <div className="data-style common-data">
            <CurrentPhaseSupply />
          </div>

          <div className="data-style common-data">
            <CurrentPhaseMinted />
          </div>

          <div className="data-style common-data">
            <ClaimedNFTSupply />
          </div>
        </div>
        <div>
          <ClaimStatusPerWallet />
        </div>
        <div className="data-style price">
          <CurrentPhasePrice />
        </div>
      </div>
      <Claim />
    </>
  );
}
