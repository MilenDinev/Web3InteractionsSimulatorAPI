import { useActiveClaimCondition } from '@thirdweb-dev/react';
import { GetContract } from '../utils/GetContract';
import { useNFTs } from "@thirdweb-dev/react";



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









// const { data:nfts, isLoading:loading, error:er } = useNFTs(contract,
//   {
//     // For example, to only return the first 50 NFTs in the collection
//     count: 352,
//     start: 0,
//   }
// );
// loading ? (console.log("isLoading")) :
// console.log(nfts.forEach(nft => {
//   console.log(nft.owner);
// }));