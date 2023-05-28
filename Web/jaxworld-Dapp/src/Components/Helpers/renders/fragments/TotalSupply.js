import { GetTotalSupply } from '../../liveData/GetTotalSupply';
import { Loading } from '../customization/Spinner';

export function TotalSupply() {
  const { supply } = GetTotalSupply();
  const totalSupply = supply === 0 ? <Loading /> : supply;

  return (
    <>
      <label>
        Total Supply: <b>{totalSupply}</b> G Minions
      </label>
    </>
  );
}
