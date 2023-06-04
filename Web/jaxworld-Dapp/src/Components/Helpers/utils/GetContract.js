import { useContract } from '@thirdweb-dev/react';

export function GetContract() {

    const { contract, isLoading } = useContract('0x8d556299531B2dCE5A3c448E22Fafc346d004B61');


return {
    contract,
    isLoading
};
   
}




