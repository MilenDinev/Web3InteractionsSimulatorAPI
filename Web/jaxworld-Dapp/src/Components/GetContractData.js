import { ContractAddress } from "./ContractData";
import { useActiveClaimConditionForWallet } from "@thirdweb-dev/react";
import { UserAddress } from "./Helpers/UserAddress";
import { NFTClaimedSupply } from "./GetNFTClaimedSupply";
import '../App.css';

export function ContractData() {
const {address } = UserAddress();
const { contract } = ContractAddress();
const { data : contractData, isLoading: status, error:errorMsg } = useActiveClaimConditionForWallet(
    contract,
    address,
  );
    
const { claimedTokens: claimed } = NFTClaimedSupply();

return (
    <>
      {status ? (
        <p>Loading...</p>
      ) : 
        errorMsg!=null ?   
        <>  
        <small>{errorMsg.toString()}</small>
        <br/>
        </>
        : (
        <>       
          <div className="text-center form-control border-0 bg-secondary bg-gradient rounded-5 p-2 text-white text-opacity-75 bg-opacity-10 form-floating mb-3 Fonts">
            <hr className="my-2"/>
            <h4>Total Supply: <b>{5000}</b> G Minions<hr className="my-2"/></h4>
            <h4>Private Mint: <b>{contractData.maxClaimableSupply}</b> units <hr className="my-2"/></h4>
            <h5>Mint Price: <b>{contractData.price.toString()[0]}.00 {contractData.currencyMetadata.symbol}</b><hr className="my-2"/></h5>
            <h5>Minted: <b>{claimed.toNumber(Int32Array)}</b><hr className="my-2"/></h5>
            <h5>Availabe: <b>{contractData.currentMintSupply}</b><hr className="my-2"/></h5>       
            <h5>You can claim: <b>{contractData.maxClaimablePerWallet}</b><hr className="my-2"/></h5>
          </div>

        </>
      )}
    </>
  );
  }