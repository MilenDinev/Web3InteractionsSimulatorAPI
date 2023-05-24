import { useClaimIneligibilityReasons } from "@thirdweb-dev/react";
import { UserAddress } from "../utils/GetUserAddress";
import { GetContract } from "../utils/GetContract";

export  function Eligibility() {

  const { contract } = GetContract();
  const { address } = UserAddress();


  const { data, isLoading, error } =  useClaimIneligibilityReasons(contract, {
    walletAddress: address,
    quantity: 1
  });


  return {
    data,
    isLoading,
    error
  };
}
