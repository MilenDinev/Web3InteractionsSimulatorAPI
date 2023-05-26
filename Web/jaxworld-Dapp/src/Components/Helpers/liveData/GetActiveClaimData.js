import { useActiveClaimCondition } from "@thirdweb-dev/react";
import { GetContract } from "../utils/GetContract";
// Your smart contract address


export function GetActiveClaimData() {

    const { contract} = GetContract();
    const { data, isLoading, error } = useActiveClaimCondition(
        contract
      );
        
  return {
        data,
        isLoading,
        error     
    };
}