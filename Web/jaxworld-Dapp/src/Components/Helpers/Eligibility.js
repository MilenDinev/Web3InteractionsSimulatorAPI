import { useClaimIneligibilityReasons } from "@thirdweb-dev/react";
import { ContractAddress } from "./ContractData";
import { UserAddress } from "./UserAddress";
import { render } from "@testing-library/react";

export function Eligibility() {
  const { contract } = ContractAddress();
  const address = UserAddress();
  const {
    data: eligibility,
    isLoading: status,
    error: errorL,
  } = useClaimIneligibilityReasons(contract, {
    walletAddress: address || "",
    quantity: 1,
  });

  return (
    <>
      if (errorL) {<p>{errorL}</p>}
      {status ? (
        <p>Loading...</p>
      ) : (
        <div>
          {<p>{eligibility} </p>}
          <br />
          <p>Test</p>
        </div>
      )}
    </>
  );
}
