import { useClaimedNFTSupply } from '@thirdweb-dev/react';
import { GetContract } from '../utils/GetContract';
// Your smart contract address


export function NFTClaimedSupply() {

  const { contract } = GetContract();
  const { data, isLoading, error } = useClaimedNFTSupply(contract);

  return {
    data,
    isLoading,
    error
  };
}