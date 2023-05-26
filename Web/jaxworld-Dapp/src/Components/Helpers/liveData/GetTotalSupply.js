import { useEffect, useState } from "react";
import { GetContract } from "../utils/GetContract";

export function GetTotalSupply() {
  const { contract, isLoading } = GetContract();

  const initialSupply = 0;

  const [supply, setTotalSupply] = useState(initialSupply);

  useEffect(() => {
    (async () => {
      setTotalSupply((isLoading ? 0 : ((await contract.erc721.totalCount()).toNumber(Int32Array))));
    })();
  });


  return {
    supply,
    isLoading
  };
}
