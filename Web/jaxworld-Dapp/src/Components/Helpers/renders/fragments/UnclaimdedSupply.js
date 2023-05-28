import { GetUnclaimedSupply } from "../../liveData/GetUnclaimedSupply";
import { Loading } from "../customization/Spinner";

export function UnclaimedNFTSupply() {
  const { supply } = GetUnclaimedSupply();

  const unclaimedSupply = supply === 0 ? <Loading /> : supply;

  return (
    <>
      <label>
        Unclaimed Supply:{" "}
        <b className="data-style count-color">{unclaimedSupply}</b>
      </label>
    </>
  );
}
