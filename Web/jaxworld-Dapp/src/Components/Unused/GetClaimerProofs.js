import { useClaimerProofs } from '';
import { GetContract } from '';
import { UserAddress } from '';


export function GetClaimerProofs() {

  const { address } = UserAddress();
  const { contract } = GetContract();
  const {data, isLoading, error,} =  useClaimerProofs(contract, address);
  


  return {
    data,
    isLoading,
    error,
  };
}