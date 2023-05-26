import { useUnclaimedNFTSupply } from '';
import { ContractAddress } from '';
// Your smart contract address


export function GetUnclaimedNFTs() {

  const { contract } = ContractAddress();
  const { data, isLoading} = useUnclaimedNFTSupply(contract);

  return {
    data,
    isLoading
  };
}