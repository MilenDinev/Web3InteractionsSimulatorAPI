import { useClaimIneligibilityReasons } from '@thirdweb-dev/react';
import { GetContract } from '../../utils/GetContract'; 
import { UserAddress } from '../../utils/GetUserAddress'; 
import { Loading } from '../customization/Spinner';

export function ClaimStatusPerWallet() {
  const { address } = UserAddress();
  const { contract } = GetContract();
  const claimQuantity = 1;

  const { data, isLoading } =  useClaimIneligibilityReasons(contract, {
    walletAddress: address || '',
    quantity: 1
  });



  const claimAvailablePerWallet = isLoading ? (
    <div className="data-style eligibility">
      <label>
        <Loading />
      </label>
    </div>
  ) : data.length > 0 ? (
    <div className="data-style eligibility negative">
      <label>You are not allowed to claim</label>
    </div>
  ) : data.length === 0 ? (
    <div className="data-style eligibility positive">
      <label>Available to Claim: {claimQuantity}</label>
    </div>
  ) : (
    <div className="data-style eligibility negative">
      <label>You are not allowed to claim</label>
    </div>
  );

  return <>{claimAvailablePerWallet}</>;
}
