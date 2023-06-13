import { useClaimIneligibilityReasons } from '@thirdweb-dev/react';
import { GetContract } from '../../utils/GetContract'; 
import { UserAddress } from '../../utils/GetUserAddress'; 
import { Loading } from '../customization/Spinner';
import { STATUS } from '../../constants/claimstatus.ts';

export function ClaimStatusPerWallet() {
  const { address } = UserAddress();
  const { contract } = GetContract();


  const { data, isLoading } =  useClaimIneligibilityReasons(contract, {
    walletAddress: address || '',
    quantity: STATUS.claimQuantity
  });



  const claimAvailablePerWallet = isLoading ? (
    <div className="data-style eligibility">
      <label>
        <Loading />
      </label>
    </div>
  ) : data.length > 0 ? (
    <div className="data-style eligibility negative">
      <label>{STATUS.notAllowed}</label>
    </div>
  ) : data.length === 0 ? (
    <div className="data-style eligibility positive">
      <label>{STATUS.available}</label>
    </div>
  ) : (
    <div className="data-style eligibility negative">
      <label>{STATUS.notAllowed}</label>
    </div>
  );

  return <>{claimAvailablePerWallet}</>;
}
