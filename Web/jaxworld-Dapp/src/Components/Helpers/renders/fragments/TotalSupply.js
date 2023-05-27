import { GetTotalSupply } from "../../liveData/GetTotalSupply";
import { Loading } from "../customization/Spinner";

export function TotalSupply() {
  const { supply } = GetTotalSupply();
  const totalSupply = supply === 0 ? <Loading/> : supply;

  return (
    <>
      <p className="fonts-style total-supply">
        Total Supply: <b>{totalSupply}</b> G Minions
      </p>
    </>
  );
}
