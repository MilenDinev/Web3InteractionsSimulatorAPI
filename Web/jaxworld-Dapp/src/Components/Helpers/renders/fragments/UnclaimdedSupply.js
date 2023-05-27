import { GetUnclaimedSupply } from "../../liveData/GetUnclaimedSupply";
import { Loading } from "../customization/Spinner";

export function UnclaimedNFTSupply() {
  const { supply } = GetUnclaimedSupply();

  const unclaimedSupply = supply === 0 ? <Loading/>: supply;

  return (
    <>
      <p className="fonts-style common-data">
        Unclaimed Supply: <b>{ unclaimedSupply }</b>
        <hr className="my-2" />
      </p>
    </>
  );
}
