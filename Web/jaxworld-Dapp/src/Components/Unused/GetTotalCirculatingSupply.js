import { useTotalCirculatingSupply } from '';
import { ContractAddress } from '';
// Your smart contract address


export function GetTotalCirculatingSupply() {

    const { contract } = ContractAddress();
    const { data:totalSupplyData, isLoading, error } = useTotalCirculatingSupply(contract);

      return {
          totalSupplyData,
          isLoading,
          error    
    };
}