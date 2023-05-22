import { useUnclaimedNFTSupply } from "@thirdweb-dev/react";
import { ContractAddress } from "./GetContract";
// Your smart contract address


export function GetUnclaimedSupply() {

  const { contract } = ContractAddress();
  const { data, isLoading} = useUnclaimedNFTSupply(contract);

  return {
    data,
    isLoading
  };
}