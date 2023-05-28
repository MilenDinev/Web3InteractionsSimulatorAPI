import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
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
        Minted in Current Event:{' '}
        <b className="data-style count-color">{currentEventMinted}</b>
      </label>
    </>
  );
}
