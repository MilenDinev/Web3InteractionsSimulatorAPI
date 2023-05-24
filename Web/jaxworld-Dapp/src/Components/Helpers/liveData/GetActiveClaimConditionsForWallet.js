import { useActiveClaimConditionForWallet } from "@thirdweb-dev/react";
import { UserAddress } from "../utils/GetUserAddress";
import { GetContract } from "../utils/GetContract";


export function GetActiveDataPerWallet() {

    const { address } = UserAddress();
    const { contract } = GetContract();
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