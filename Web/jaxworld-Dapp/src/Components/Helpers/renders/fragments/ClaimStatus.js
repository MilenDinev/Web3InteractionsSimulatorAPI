import { CanClaim } from '../../liveData/CanClaim';
import { Loading } from '../customization/Spinner';

export function ClaimStatusPerWallet() {
  const quantity = 1;

  const { claim, isLoading } = CanClaim();

  const claimAvailablePerWallet = isLoading ? (
    <div className="data-style eligibility">
      <label>
        <Loading />
      </label>
    </div>
  ) : isLoading && !claim? (
    <div className="data-style eligibility negative">
      <label>You are not allowed to claim</label>
    </div>
  ) : !isLoading && claim ? (
    <div className="data-style eligibility positive">
      <label>Available to Claim: {quantity}</label>
    </div>
  ) : (
    <div className="data-style eligibility negative">
      <label>You are not allowed to claim</label>
    </div>
  );

  return <>{claimAvailablePerWallet}</>;
}
