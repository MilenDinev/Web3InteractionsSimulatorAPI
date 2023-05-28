import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
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
        Private Mint Supply:{' '}
        <b className="data-style count-color">{currentMintSupply}</b>
      </label>
    </>
  );
}
