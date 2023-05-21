import { useContract } from "@thirdweb-dev/react";

export function ContractAddress() {

    const { contract } = useContract("0x34c66A74Ca7F00EC901CC082c7738Fe0734d1d47");

return {
    contract
};
   
}