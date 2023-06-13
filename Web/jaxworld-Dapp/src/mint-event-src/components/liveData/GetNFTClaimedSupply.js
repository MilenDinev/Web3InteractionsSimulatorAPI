import { useClaimedNFTSupply } from '@thirdweb-dev/react';
import { GetContract } from '../utils/GetContract';

export function NFTClaimedSupply() {

  const { contract } = GetContract();
  const { data, isLoading, error } = useClaimedNFTSupply(contract);

  return {
    data,
    isLoading,
    error
  };
}