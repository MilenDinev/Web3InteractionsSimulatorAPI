import { NFTClaimedSupply } from "../../liveData/GetNFTClaimedSupply";
import { Loading } from "../customization/Spinner";

export function ClaimedNFTSupply() {
  const { data: claimed, isLoading, error } = NFTClaimedSupply();

  const totalMinted = isLoading
    ? <Loading/>
    : error != null
    ? error.toString()
    : claimed.toNumber(Int32Array);

  return (
    <>
      <h5 className="fonts">
      <hr className="my-2"/>
        Minted in Total: <b>{totalMinted}</b> <hr className="my-2" />
      </h5>
    </>
  );
}
