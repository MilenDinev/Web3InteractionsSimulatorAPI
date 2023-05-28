import { useEffect, useState } from 'react';
import { GetContract } from '../utils/GetContract';
import { UserAddress } from '../utils/GetUserAddress';

export function CanClaim() {

  const { address } = UserAddress();
  const { contract, isLoading } = GetContract();

  
  const quantity = 1;  
  const initialClaim = false ;

  const [claim, setClaim] = useState(initialClaim);

  useEffect(() => {
    (async () => {
      if (!isLoading)
      {
        setClaim( await contract.erc721.claimConditions.canClaim(quantity, address));
      }
   })() ;
    });
  

  return {
    claim,
    isLoading
  };
}