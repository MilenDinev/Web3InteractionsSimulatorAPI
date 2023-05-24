import { useEffect, useState } from "react";
import { ContractAddress } from "../Helpers/utils/GetContract";
import { UserAddress } from "../Helpers/utils/GetUserAddress";
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