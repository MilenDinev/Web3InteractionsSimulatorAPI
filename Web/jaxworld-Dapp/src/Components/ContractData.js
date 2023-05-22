import { useConnectionStatus } from "@thirdweb-dev/react";
import { GetAllClaimData } from "./Helpers/actions/GetAllClaimConditions";
import { GetActiveDataPerWallet } from "./Helpers/actions/GetActiveClaimConditionsForWallet";
import { Eligibility } from "./Helpers/actions/GetEligibility";
import { GetCollectionData } from "./Helpers/actions/GetCollectionData";
import { NFTClaimedSupply } from "./Helpers/actions/GetNFTClaimedSupply";
import { GetUnclaimedSupply } from "./Helpers/actions/GetUnclaimedSupply";
import '../App.css';

export function ContractData() {
  const {data:allClaimData, isLoading, error:allDataError} =  GetAllClaimData();
  const connectionStatus = useConnectionStatus();
  const {data:collectionDataPerWallet, isLoading:statusPerWallet, error} =  GetActiveDataPerWallet();
  const {data:reason, isLoading:eligibilityLoading} =  Eligibility();
  const {data:collectionData, isLoading:status} =  GetCollectionData();
  const {data:unclaimedSupply, isLoading: unclaimedStatus} =  GetUnclaimedSupply();

 
  const { data: claimed, isLoading: claimedStatus } = NFTClaimedSupply();

  const totalSupply = status ? 'Loading...' : 
  error!=null ? <label>{error.toString()}</label> : 
   collectionData.length;
   
  const totalUnclaimedSupply = unclaimedStatus ? 'Loading...' : 
  error!=null ? <label>{error.toString()}</label> : 
  unclaimedSupply.toNumber(Int32Array);

  const privateMintSupplly = isLoading ? 'Loading...' : 
  error!=null ? <label>{error.toString()}</label> : 
  allClaimData[0].maxClaimableSupply;

  const currentEventMinted = isLoading ? 'Loading...' : 
  error!=null ? <label>{error.toString()}</label> :  
  allClaimData[0].currentMintSupply;

  const iReason = eligibilityLoading ? "Loading..." : error!=null ? <label>{error.toString()}</label> :
  reason[0].replace('.', ' or already claimed.');
  
  const totalMinted = claimedStatus ? 'Loading...' : error!=null ? <label>{error.toString()}</label> :
  claimed.toNumber(Int32Array);

  const claimAvailablePerWallet = connectionStatus === 'disconnected' ? (<label>You need to connect...</label>) :
   statusPerWallet ? 'Loading...' : 
   collectionDataPerWallet.maxClaimablePerWallet ==='0' ? <label> {iReason} </label> : 
   iReason!=="Loading..." ? <label> {iReason[0]} </label> :
   error!=null ? <label>{error.toString()}</label> : 
   collectionDataPerWallet.maxClaimablePerWallet;

  const mintPriceValue = isLoading ? (<p>Loading...</p>) : 
  allDataError!=null ? <label>{allDataError.toString()}</label>: 
  allClaimData[0].price.toNumber();

  const mintPriceSymbol = isLoading ? (<p>Loading...</p>) : 
  allDataError!=null ? <label>{allDataError.toString()}</label>: 
  allClaimData[0].currencyMetadata.symbol;

return (
        <>       
          <div className="text-center form-control border-0 bg-secondary bg-gradient rounded-5 p-2 text-white text-opacity-75 bg-opacity-10 form-floating mb-3 Fonts">
            <hr className="my-2"/>
            <h5>Total Supply: <b>{totalSupply}</b> G Minions<hr className="my-2"/></h5>
            <h5>Unclaimed Supply: <b>{totalUnclaimedSupply}</b><hr className="my-2"/></h5>
            <h5>Private Mint Supply: <b>{privateMintSupplly}</b> <hr className="my-2"/></h5>
            <h6>Minted in Current Event: <b>{currentEventMinted}</b> <hr className="my-2"/></h6>       
            <h6>Minted in Total: <b>{totalMinted}</b> <hr className="my-2"/></h6>
            <h6>Available to Claim:<b> {claimAvailablePerWallet}</b><hr className="my-2"/></h6>
            <br></br>
            <h4>Mint Price: <b>{mintPriceValue} {mintPriceSymbol}</b></h4>
          </div>
        </>
  );
  }