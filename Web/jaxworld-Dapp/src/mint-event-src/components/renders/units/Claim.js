import { Web3Button } from '@thirdweb-dev/react';
import { Toast } from '../fragments/Toast';
import { Agreements } from '../fragments/Agreements';
import { Conditions } from '../fragments/Conditions';
import { Eligibility } from '../../liveData/GetEligibility';
import { Loading } from '../customization/Spinner';
import { CONTRACT } from '../../constants/contract.ts';
export function Claim() {
  const { submit, success, error } = Toast();
  const { inputs, termsOfUse, privacyPolicy } = Agreements();
  const { output: conditions } = Conditions();
  const { data, isLoading, } = Eligibility();




const claim =  isLoading ? 
<>
        <div className="conditions">
            <Loading /> 
        </div>
        {inputs}
        </> :
!termsOfUse || !privacyPolicy ? (
  <>
    {conditions}
    {inputs}
  </>
) : data.length > 0 && !isLoading ? (
  <>
    <div className="d-flex flex-wrap justify-content-center">
      <label className="not-allowed-to-claim-pl button">
        Not allowed
      </label>
    </div>
    {inputs}
  </>
) : (
  <>
    <div className="d-flex flex-wrap justify-content-center">
      <Web3Button
        dropdownPosition={{ side: 'bottom', align: 'center' }}
        contractAddress={CONTRACT.address}
        action={(contract) => contract.erc721.claim(1)}
        onSuccess={success}
        onSubmit={submit}
        onError={error}
        className="claim-pl button"
      >
        Claim NFT
      </Web3Button>
    </div>
    {inputs}
  </>
);



  return <>{claim}</>;
}