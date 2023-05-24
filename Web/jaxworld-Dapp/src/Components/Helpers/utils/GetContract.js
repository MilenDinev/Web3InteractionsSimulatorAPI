import { useContract } from "@thirdweb-dev/react";

export function GetContract() {

    const { contract, isLoading } = useContract("0x7e327E167FD7a339e410dd34f17e2856388e0a9a");


return {
    contract,
    isLoading
};
   
}




