import {useState } from "react";

export function Agreements() {

    const [privacyPolicy, setPrivacyPolicy] = useState(false);

    const handlePrivacyPolicy = (event) => {
          setPrivacyPolicy(event.target.checked
            );
      };


    const [termsOfUse, setTermsOfUse] = useState(false);
    const handleTermsOfUse = (event) => {
      setTermsOfUse(event.target.checked
        );
    };
    

const inputs =   <>
    <hr className="my-4"></hr>
    <div className="form-control border-0 bg-secondary bg-gradient rounded-4 p-2 text-muted bg-opacity-10 form-floating mb-3">
      <div className="form-check text-opacity-75">
        <input
          className="form-check-input"
          type="checkbox"
          onChange={handlePrivacyPolicy}       
        />                  
        <label className="form-check-label">
          Agree with Privacy Policy
        </label>
      </div>
  
  
      <div className="form-check text-opacity-75">
        <input
          className="form-check-input"
          type="checkbox"
          onChange={handleTermsOfUse}
        />
        <label className="form-check-label">
          Agree with Terms Of Use
        </label>
      </div>
  
    <small className="text-white">
      It is necessary to agree to the Privacy Policy and Terms of Use.
    </small>
    </div>
    </>;

  return {
    termsOfUse,
    privacyPolicy,
    inputs
    };
}