import { CONDITIONS } from '../../constants/conditions.ts';

export function Conditions() {
  const output = (
    <>
      <div className="conditions">
        <label>{CONDITIONS.message}</label>
      </div>
    </>
  );

  return {
    output,
  };
}
