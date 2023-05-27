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
    <hr className="my-2"></hr>
    <div className=" fonts border-0 mt-2">
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
    </div>
    </>;

  return {
    termsOfUse,
    privacyPolicy,
    inputs
    };
}