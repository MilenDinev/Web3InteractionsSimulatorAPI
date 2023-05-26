import { GetActiveClaimData } from "../../liveData/GetActiveClaimData";
import { Loading } from "../customization/Spinner";

export function CurrentPhaseSupply() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const currentMintSupply = isLoading
    ? <Loading/>
    : error != null
    ? error.toString()
    : allClaimData.maxClaimableSupply;

  const currentEventMinted = isLoading
    ? <Loading/>
    : error != null
    ? error.toString()
    : allClaimData.currentMintSupply;

  return (
    <>
      <h5 className="fonts">
        Private Mint Supply: <b>{currentMintSupply}</b> <hr className="my-2" />
      </h5>
      <h5 className="fonts">
        Minted in Current Event: <b>{currentEventMinted}</b>{" "}
      </h5>
    </>
  );
}
