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
        <div className="conditions text-center">
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
    <div className="d-flex justify-content-center">
      <label className="btn-none custom-box-main mrg-b-lg-1 mrg-t-lg-5 font-size-m-br text-fonts text-clr-lg text-ac">
        Not allowed
      </label>
    </div>
    {inputs}
  </>
) : (
  <>
    <div className="d-flex justify-content-center">
      <Web3Button
        dropdownPosition={{ side: 'bottom', align: 'center' }}
        contractAddress={CONTRACT.address}
        action={(contract) => contract.erc721.claim(1)}
        onSuccess={success}
        onSubmit={submit}
        onError={error}
        className="custom-box-main text-fonts font-size-m-br text-clr-lg text-ac mrg-t-m-8 mrg-b-m-9 claim-pl button hover"
      >
        Claim NFT
      </Web3Button>
    </div>
    {inputs}
  </>
);



  return <>{claim}</>;
}