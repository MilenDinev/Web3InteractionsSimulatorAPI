import React from "react";
import { Web3Button } from "@thirdweb-dev/react";
import { GetToast } from "../fragments/Toast";
import { GetAgreements } from "../fragments/GetAgreements";

export function Claim() {

  const {toastContainer, submit, success, error} = GetToast();
  const {inputs, termsOfUse , privacyPolicy} = GetAgreements();

  return (
<>
{!termsOfUse || !privacyPolicy ? (

    <>
    <div className="d-flex justify-content-center">
    <div> Please read and agree with Privacy policy and Terms of Use in order to continue. </div>
    <br/>
    </div>
    {inputs} 
    </>
    )
    : (
      <>
  <div className="d-flex justify-content-center">
    <Web3Button
      dropdownPosition={{ side: "bottom", align: "center" }}
      contractAddress="0x7e327E167FD7a339e410dd34f17e2856388e0a9a"
      action={(contract) => contract.erc721.claim(1)}
      onSuccess={success}
      onSubmit= {submit}
      onError={error}
      // Logic to execute when clicked
    >
      Claim NFT
    </Web3Button>

    {toastContainer}

    </div>
    {inputs}
    </>
    )}
  </>
  );
}