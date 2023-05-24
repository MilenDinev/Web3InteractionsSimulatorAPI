import { GetTotalSupply } from '../../liveData/GetTotalSupply';
import './../../../../App.css';

export function TotalSupply() {
  const { supply } = GetTotalSupply();
  const totalSupply = supply === 0 ? 'Loading...' : supply;

  return (
    <>
      <h5 className="Fonts">
      <hr className="my-2" />
        Total Supply: <b>{totalSupply}</b> G Minions
        <hr className="my-2" />
      </h5>
    </>
  );
}
