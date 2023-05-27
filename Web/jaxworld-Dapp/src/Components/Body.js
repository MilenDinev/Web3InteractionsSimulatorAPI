import React from "react";
import { Claim } from "./Helpers/renders/units/Claim";
import { ContractData } from "./Helpers/renders/units/ContractData";
import { HeroContent } from "./Helpers/renders/units/HeroContent";
import { Toast } from "./Helpers/renders/fragments/Toast";

export function Body() {



  return (
      <>
      <BodyContent/>
      </>   
  );
}


function BodyContent() {

  const{toastContainer} = Toast();
  const handleSubmit = event => {
    event.preventDefault();


  };
  return (
    <div className="container col-xl-10 col-xxl-8 px-5 py-4 mb-5">
      <div className="row align-items-center g-lg-6 py-3 mb-5">
          <HeroContent/>
        <div className="col-md-10 mx-auto col-lg-4 mb-5">
          <form className="p-4 p-md-5 card" onSubmit={handleSubmit}>
            <ContractData />
            <Claim />
          </form>
          {toastContainer}   
        </div>

      </div>
    </div>
  );
}

