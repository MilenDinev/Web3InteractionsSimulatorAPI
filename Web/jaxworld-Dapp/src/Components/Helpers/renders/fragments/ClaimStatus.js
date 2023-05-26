import { CanClaim } from '../../liveData/CanClaim';
import { Loading } from '../customization/Spinner';
import './../../../../App.css';

export function ClaimStatusPerWallet() {

    const quantity = 1;

    const {claim, isLoading} = CanClaim();
    


    const claimAvailablePerWallet =  isLoading ? <Loading/> : 
    !isLoading && !claim ? 'You are not allowed to claim' : !isLoading && claim ?
    'Available to Claim: ' + quantity : 'You are not allowed to claim';

  return (
    <>
    <h5 className="fonts"><b className="text-white text-opacity-75">{claimAvailablePerWallet}</b><hr className="my-2"/></h5>
    </>
  );
}
