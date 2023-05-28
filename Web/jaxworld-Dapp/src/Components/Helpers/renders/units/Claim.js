import { Web3Button } from "@thirdweb-dev/react";
import { Toast } from "../fragments/Toast";
import { Agreements } from "../fragments/Agreements";
import { Conditions } from "../fragments/Conditions";

export function Claim() {
  const { submit, success, error } = Toast();
  const { inputs, termsOfUse, privacyPolicy } = Agreements();
  const { output: conditions } = Conditions();

  return (
    <>
      {!termsOfUse || !privacyPolicy ? (
        <>
          {conditions}
          {inputs}
        </>
      ) : (
        <>
          <div className="d-flex flex-wrap justify-content-center">
            <Web3Button
              dropdownPosition={{ side: "bottom", align: "center" }}
              contractAddress="0x7e327E167FD7a339e410dd34f17e2856388e0a9a"
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
      )}
    </>
  );
}
