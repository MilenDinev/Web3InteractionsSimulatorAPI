import { GetTotalSupply } from '../../liveData/GetTotalSupply';
import { TOTALSTATUS } from '../../constants/totalStatus.ts';
import { Loading } from '../customization/Spinner';

export function TotalSupply() {
  const { supply } = GetTotalSupply();
  const totalSupply = supply === 0 ? <Loading /> : supply;

  return (
    <>
      <label>
        {TOTALSTATUS.totalSupplyMessage}{totalSupply} {TOTALSTATUS.collectionName}
      </label>
    </>
  );
}
