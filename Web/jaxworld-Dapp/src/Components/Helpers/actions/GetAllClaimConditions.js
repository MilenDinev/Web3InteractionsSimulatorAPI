import { useClaimConditions } from "@thirdweb-dev/react";
import { ContractAddress } from "./GetContract";
// Your smart contract address


export function GetAllClaimData() {

    const { contract } = ContractAddress();
    const { data, isLoading, error } =  useClaimConditions(
        contract,
      );
      


  return {
        data,
        isLoading,
        error     
    };
}