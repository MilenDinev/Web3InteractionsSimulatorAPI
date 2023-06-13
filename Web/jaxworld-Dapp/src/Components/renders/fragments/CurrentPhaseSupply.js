import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
import { CURRENTPHASE } from '../../constants/currentPhaseStatus.ts';
import { Loading } from '../customization/Spinner';

export function CurrentPhaseSupply() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const currentMintSupply = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    allClaimData.maxClaimableSupply
  );

  return (
    <>
      <label>
        {CURRENTPHASE.mintSupplyMessage}
        <b className="data-style count-color">{currentMintSupply}</b>
      </label>
    </>
  );
}
