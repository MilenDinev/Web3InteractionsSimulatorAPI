import { useNFTs } from '';
import { ContractAddress } from '';



export function GetCollectionData() {

    const { contract } = ContractAddress();
    const { data, isLoading, error } = useNFTs(contract);

      return {
          data,
          isLoading,
          error    
    };
}