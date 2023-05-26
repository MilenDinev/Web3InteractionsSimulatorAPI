import React from "react";
import { Web3Button } from "@thirdweb-dev/react";
import { Toast } from "../fragments/Toast";
import { Agreements } from "../fragments/Agreements";
import { Conditions } from "../fragments/Conditions";

export function Claim() {

  const {toastContainer, submit, success, error} = Toast();
  const {inputs, termsOfUse , privacyPolicy} = Agreements();
  const {output:conditions} = Conditions();

  return (
<>
{!termsOfUse || !privacyPolicy ? (

    <>
    <div className="d-flex justify-content-center">
      {conditions}
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