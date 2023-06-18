import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
import { CURRENTPHASE } from '../../constants/currentPhaseStatus.ts';
import { Loading } from '../customization/Spinner';

export function CurrentPhaseMinted() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const currentEventMinted = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    allClaimData.currentMintSupply
  );

  return (
    <>
      <label>
        {CURRENTPHASE.mintedMessage}
        <b className="text-clr-lg">{currentEventMinted}</b>
      </label>
    </>
  );
}
