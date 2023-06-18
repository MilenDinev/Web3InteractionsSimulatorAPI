import { GetUnclaimedSupply } from '../../liveData/GetUnclaimedSupply';
import { TOTALSTATUS } from '../../constants/totalStatus.ts';
import { Loading } from '../customization/Spinner';

export function UnclaimedNFTSupply() {
  const { supply } = GetUnclaimedSupply();

  const unclaimedSupply = supply === 0 ? <Loading /> : supply;

  return (
    <>
      <label>
        {TOTALSTATUS.unclaimedTotalMessage}
        <b className="text-clr-lg">{unclaimedSupply}</b>
      </label>
    </>
  );
}
