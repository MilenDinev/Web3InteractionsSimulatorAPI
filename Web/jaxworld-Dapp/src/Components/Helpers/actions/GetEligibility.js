import { useClaimIneligibilityReasons } from "@thirdweb-dev/react";
import { UserAddress } from "./GetUserAddress";
import { ContractAddress } from "./GetContract";
import { GetActiveDataPerWallet } from "./GetActiveClaimConditionsForWallet";

export  function Eligibility() {

  const { contract } = ContractAddress();
  const { address } = UserAddress();

  const {data:cDataPerWallet, isLoading:Status} =   GetActiveDataPerWallet();

  const collectionDataPerWallet = Status? false : cDataPerWallet;

  const { data, isLoading, error } =  useClaimIneligibilityReasons(contract, {
    walletAddress: address,
    quantity: collectionDataPerWallet.maxClaimablePerWallet
  });


  return {
    data,
    isLoading,
    error
  };
}
