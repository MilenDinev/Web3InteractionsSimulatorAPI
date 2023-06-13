import { useContract } from '@thirdweb-dev/react';
import { CONTRACT } from '../constants/contract.ts';

export function GetContract() {

const { contract, isLoading } = useContract(CONTRACT.address); 


return {
    contract,
    isLoading
};
   
}

