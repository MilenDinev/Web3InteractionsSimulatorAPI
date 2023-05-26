import { useEffect, useState } from "";
import { GetContract } from "";
import { UserAddress } from "";
// Your smart contract address

export function GetBalance() {

    const { address } = UserAddress();
    const { contract, isLoading } = GetContract();
  
    
    const initialBalance = 0 ;
  
    const [balance, setBalance] = useState(initialBalance);
  
    useEffect(() => {
      (async () => {
          setBalance(( isLoading ? 0 : (await contract.erc721.balanceOf(address)).toNumber(Int32Array)));
     })() ;
      });
    
  
    return {
      balance,
    };
  }