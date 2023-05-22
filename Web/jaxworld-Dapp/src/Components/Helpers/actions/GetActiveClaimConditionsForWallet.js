import { useActiveClaimConditionForWallet } from "@thirdweb-dev/react";
import { UserAddress } from "./GetUserAddress";
import { ContractAddress } from "./GetContract";


export function GetActiveDataPerWallet() {

    const { address } = UserAddress();
    const { contract } = ContractAddress();
    const { data, isLoading, error } = useActiveClaimConditionForWallet(
        contract,
        address,
      );

      
      return {
        data,
        isLoading,
        error
    };
}