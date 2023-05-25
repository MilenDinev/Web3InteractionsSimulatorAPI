import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
import { Loading } from '../customization/Spinner';
import './../../../../App.css';

export function CurrentPhasePrice() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const mintPriceValue = isLoading
    ? <Loading/>
    : error != null
    ? error.toString()
    : allClaimData.price.toNumber();

  const mintPriceSymbol = isLoading
    ? isLoading
    : error != null
    ? error.toString()
    : allClaimData.currencyMetadata.symbol;

  return (
    <>
      <h4>
        Mint Price:{' '}
        <b>
          {mintPriceValue} {mintPriceSymbol}
        </b>
      </h4>
    </>
  );
}
