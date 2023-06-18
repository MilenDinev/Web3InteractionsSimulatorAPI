import { NFTClaimedSupply } from '../../liveData/GetNFTClaimedSupply';
import { TOTALSTATUS } from '../../constants/totalStatus.ts';
import { Loading } from '../customization/Spinner';

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
        {TOTALSTATUS.mintedInTotalMessage}<b className="text-clr-lg">{totalMinted}</b>
      </label>
    </>
  );
}
