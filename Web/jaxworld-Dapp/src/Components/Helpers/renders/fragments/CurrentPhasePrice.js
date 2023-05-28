import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
import { Loading } from '../customization/Spinner';

export function CurrentPhasePrice() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const mintPriceValue = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    allClaimData.price.toNumber()
  );

  const mintPriceSymbol = isLoading
    ? isLoading
    : error != null
    ? error.toString()
    : allClaimData.currencyMetadata.symbol;

  return (
    <>
      <label>
        Mint Price:{' '}
        <b className="data-style count-color">
          {mintPriceValue} {mintPriceSymbol}
        </b>
      </label>
    </>
  );
}
