import { useEffect, useState } from '';
import { GetContract } from '';
import { UserAddress } from '';


export function GetBalanceOf() {

  const { address } = UserAddress();
  const { contract, isLoading } = GetContract();

  
  const initialBalanceOf = 0 ;

  const [balanceOf, setBalanceOf] = useState(initialBalanceOf);

  useEffect(() => {
    (async () => {
        setBalanceOf(( isLoading ? 0 : (await contract.erc721.balanceOf(address)).toNumber(Int32Array)));
   })() ;
    });
  

  return {
    balanceOf,
  };
}