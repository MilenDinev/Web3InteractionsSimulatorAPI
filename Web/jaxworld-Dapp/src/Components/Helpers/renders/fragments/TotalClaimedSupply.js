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
      <p className="fonts-style common-data">
      <hr className="my-2"/>
        Minted in Total: <b>{totalMinted}</b>
      </p>
    </>
  );
}
