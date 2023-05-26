import { useEffect, useState } from '';
import { ContractAddress } from '';
import { UserAddress } from '';
// Your smart contract address

export function GetClaimInegibility() {

  const { contract } = ContractAddress();
  const { address } = UserAddress();
  
  const quantity = 1;  
  const initialClaimInegibility = [] ;

  const [reason, setInegibilityReasons] = useState(initialClaimInegibility);

  useEffect(() => {
    (async () => {
      setInegibilityReasons(( await contract.erc721.getClaimIneligibilityReasons(quantity, address)));
   })() ;
});
  


console.log(reason);


  return {
    reason,
  };
}