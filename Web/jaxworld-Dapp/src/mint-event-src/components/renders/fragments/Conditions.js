import { CONDITIONS } from '../../constants/conditions.ts';

export function Conditions() {
  const output = (
    <>
      <div className="custom-box-red con-an pd-lg-1 text-fonts text-clr-lg text-ac font-size-s-br">
        <label>{CONDITIONS.message}</label>
      </div>
    </>
  );

  return {
    output,
  };
}
