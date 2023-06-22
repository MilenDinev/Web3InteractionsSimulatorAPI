import { GetActiveClaimData } from '../../liveData/GetActiveClaimData';
import { CURRENTPHASE } from '../../constants/currentPhaseStatus.ts';
import { Loading } from '../customization/Spinner';

export function CurrentPhasePrice() {
  const { data: allClaimData, isLoading, error } = GetActiveClaimData();

  const mintPriceValue = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    allClaimData.price.toBigInt()
  );

  const stringPrice = mintPriceValue.toString();

  const mintPriceSymbol = isLoading
    ? isLoading
    : error != null
    ? error.toString()
    : allClaimData.currencyMetadata.symbol;

  const maxClaimPerWallet = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : (
    1
  );

  const price = isLoading ? (
    <Loading />
  ) : error != null ? (
    error.toString()
  ) : stringPrice.length > 1 ? (
    stringPrice[0] +
    '.' +
    stringPrice[1] +
    '' +
    stringPrice[2] +
   ' ' +
    mintPriceSymbol
  ) : (
    CURRENTPHASE.freeMessage
  );

  return (
    <>
      <label>
        {CURRENTPHASE.maxClaimPerWalletMessage}
        <b className="text-clr-lg">{maxClaimPerWallet}</b>
      </label>
      <br />
      <label>
        Mint Price: <b className="text-clr-lg">{price}</b>
      </label>
    </>
  );
}
