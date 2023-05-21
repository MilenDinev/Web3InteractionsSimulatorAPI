import { useAddress } from "@thirdweb-dev/react";

export function UserAddress() {

    const address = useAddress();

return{

    address

};    
}
