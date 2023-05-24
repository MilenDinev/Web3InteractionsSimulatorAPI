import { GetActiveDataPerWallet } from '../../liveData/GetActiveClaimConditionsForWallet';
import { Eligibility } from '../../liveData/GetEligibility';
import { CanClaim } from '../../liveData/CanClaim';
import { Loading } from '../customization/Spinner';
import './../../../../App.css';

export function ClaimStatusPerWallet() {

    const {data, isLoading, error} =  GetActiveDataPerWallet();
    const {claim } = CanClaim();
    
    const {data:reason, isLoading:eligibilityLoading} =  Eligibility();


    const claimAvailablePerWallet = isLoading ? <Loading/> : 
    !claim ? eligibilityLoading ? 
    <Loading/> : reason[0] :
    error!=null ? error.toString() : 
    'Available to Claim: ' + data.maxClaimablePerWallet;

  return (
    <>
    <h5 className="Fonts"><b className="text-white text-opacity-75">{claimAvailablePerWallet}</b><hr className="my-2"/></h5>
    </>
  );
}
