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
    <div className="custom-box-main text-clr-m mrg-l-lg-10 mrg-r-lg-10 text-ac">
      <label>
        <Loading />
      </label>
    </div>
  ) : data.length > 0 ? (
    <div className="mrg-l-lg-10 mrg-r-lg-10 custom-box-red font-size-lg-br text-f-obl text-ac">
      <label>{STATUS.notAllowed}</label>
    </div>
  ) : data.length === 0 ? (
    <div className=" mrg-l-lg-10 mrg-r-lg-10 custom-box-green font-size-lg-b text-ac">
      <label>{STATUS.available}</label>
    </div>
  ) : (
    <div className="mrg-l-lg-10 mrg-r-lg-10 custom-box-red font-size-lg-br text-f-obl text-ac">
      <label>{STATUS.notAllowed}</label>
    </div>
  );

  return <>{claimAvailablePerWallet}</>;
}
