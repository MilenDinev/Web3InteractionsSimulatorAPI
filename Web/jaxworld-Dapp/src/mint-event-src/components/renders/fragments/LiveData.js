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
      <div className="text-fonts font-size-lg-br">
        <div className="custom-box-main text-clr-lg text-ac mrg-t-lg-1 
        mrg-b-lg-1 mrg-l-lg-1 mrg-r-lg-1">
          <TotalSupply />
        </div>

        <div className="custom-box-main mrg-t-lg-1 mrg-b-lg-1 mrg-l-lg-10 mrg-r-lg-10 text-clr-lg text-ac">

          <div className="font-size-m text-clr-m">
            <UnclaimedNFTSupply />
          </div>

          <div className="font-size-m text-clr-m">
            <CurrentPhaseSupply />
          </div>

          <div className="font-size-m text-clr-m">
            <CurrentPhaseMinted />
          </div>

          <div className="font-size-m text-clr-m">
            <ClaimedNFTSupply />
          </div>
        </div>
        <div className="mrg-t-lg-1 mrg-b-lg-1">
          <ClaimStatusPerWallet />
        </div>
        <div className="custom-box-main mrg-t-lg-1 mrg-b-lg-1 text-clr-m text-ac">
          <CurrentPhasePrice />
        </div>
      </div>
      <Claim />
    </>
  );
}
