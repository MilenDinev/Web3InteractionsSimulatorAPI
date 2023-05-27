import React from "react";
import { Web3Button } from "@thirdweb-dev/react";
import { Toast } from "../fragments/Toast";
import { Agreements } from "../fragments/Agreements";
import { Conditions } from "../fragments/Conditions";

export function Claim() {

  const {submit, success, error} = Toast();
  const {inputs, termsOfUse , privacyPolicy} = Agreements();
  const {output:conditions} = Conditions();

  return (
<>
{!termsOfUse || !privacyPolicy ? (

    <>
    <div className="d-flex flex-wrap justify-content-center mt-3 mb-1">
      {conditions}
    </div>
    {inputs} 
    </>
    )
    : (
      <>
  <div className="d-flex flex-wrap justify-content-center mt-4 mb-3">
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

    </div>
    {inputs}
    </>
    )}
  </>
  );
}