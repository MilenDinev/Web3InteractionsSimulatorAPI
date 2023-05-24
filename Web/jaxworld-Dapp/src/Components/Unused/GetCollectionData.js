import { useNFTs } from "@thirdweb-dev/react";
import { ContractAddress } from "../Helpers/utils/GetContract";
// Your smart contract address


export function GetCollectionData() {

    const { contract } = ContractAddress();
    const { data, isLoading, error } = useNFTs(contract);

      return {
          data,
          isLoading,
          error    
    };
}