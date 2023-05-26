import { CanClaim } from "../../liveData/CanClaim";
import { Loading } from "../customization/Spinner";

export function ClaimStatusPerWallet() {
  const quantity = 1;

  const { claim, isLoading } = CanClaim();

  const claimAvailablePerWallet = isLoading ? (
    <Loading />
  ) : !isLoading && !claim ? (
    "You are not allowed to claim"
  ) : !isLoading && claim ? (
    "Available to Claim: " + quantity
  ) : (
    "You are not allowed to claim"
  );

  return (
    <>
      <p className="fonts-style eligibility">
        {claimAvailablePerWallet}
      </p>
    </>
  );
}