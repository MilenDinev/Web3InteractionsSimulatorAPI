import { useClaimedNFTSupply } from "@thirdweb-dev/react";
import { ContractAddress } from "./GetContract";
// Your smart contract address


export function NFTClaimedSupply() {

  const { contract } = ContractAddress();
  const { data, isLoading } = useClaimedNFTSupply(contract);

  return {
    data,
    isLoading
  };
}