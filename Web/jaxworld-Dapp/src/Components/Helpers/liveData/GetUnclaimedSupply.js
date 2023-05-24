import { useEffect, useState } from 'react';
import { GetContract } from '../utils/GetContract';
// Your smart contract address

export function GetUnclaimedSupply() {

  const { contract, isLoading } =  GetContract();

  const initialUnclaimedSupply = 0;

  const [supply, setUnclaimedSupply] = useState(initialUnclaimedSupply);

  useEffect(() => {
      (async () => {
        setUnclaimedSupply((isLoading ? 0 : ((await contract.erc721.totalUnclaimedSupply()).toNumber(Int32Array))));
     })() ;
  });


  return {
    supply,
  };
}




