import { NFTClaimedSupply } from "../../liveData/GetNFTClaimedSupply";
import { Loading } from "../customization/Spinner";

export function ClaimedNFTSupply() {
  const { data: claimed, isLoading, error } = NFTClaimedSupply();

  const totalMinted = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    claimed.toNumber(Int32Array)
  );

  return (
    <>
      <label>
        Minted in Total: <b className="data-style count-color">{totalMinted}</b>
      </label>
    </>
  );
}
