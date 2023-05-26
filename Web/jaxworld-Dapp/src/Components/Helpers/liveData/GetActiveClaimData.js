import { useActiveClaimCondition } from "@thirdweb-dev/react";
import { GetContract } from "../utils/GetContract";


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