import { useClaimedNFTSupply } from "@thirdweb-dev/react";
import { ContractAddress } from "./ContractData";
// Your smart contract address


export function NFTClaimedSupply() {

  const { contract } = ContractAddress();
  const { data: claimedTokens } = useClaimedNFTSupply(contract);

  return {
    claimedTokens
  };
}