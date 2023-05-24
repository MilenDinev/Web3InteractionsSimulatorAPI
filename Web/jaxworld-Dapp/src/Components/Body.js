import React from "react";
import { Claim } from "./Helpers/renders/units/Claim";
import { ContractData } from "./Helpers/renders/units/ContractData";

function Body() {


  return (
      <>
      <Form/>
      </>   
  );
}


function Form() {
  return (
    <div className="container col-xl-10 col-xxl-8 px-4 py-5">



      <div id="hero" className="row align-items-center g-lg-5 py-5">

        <div className="Fonts col-lg-7 text-center text-lg-start bg-gradient p-3 rounded-5 text-muted">
          <h4 className="display-6 fw-bolder mb-2">Jax World's Genesis NFT Collection</h4>
          <h3 className="display-6 fw-bold mb-1">G Minions</h3>
          <h1 className="display-2 fw-bold lh-1 mb-0 text-white text-opacity-75">is now available</h1>
          <p className="col-lg-10 fs-4">exclusively for our community members.</p>
        </div> 

        <div className="col-md-10 mx-auto col-lg-5">
          <form className="p-4 p-md-5 border border-secondary border-opacity-50 rounded-5 bg-transparent">
            <ContractData />
            <Claim />
    
            <hr className="my-4"></hr>
            <div className="form-control border-0 bg-secondary bg-gradient rounded-4 p-2 text-muted bg-opacity-10 form-floating mb-3">
              <div className="form-check text-opacity-75">
                <input
                  className="form-check-input"
                  type="checkbox"
                  value=""
                  id="flexCheckDefault"
                  required
                ></input>
                <label className="form-check-label" htmlFor="flexCheckDefault">
                  Agree with Privacy Policy
                </label>
              </div>
            
    
            <div className="form-check text-opacity-75">
              <input
                className="form-check-input"
                type="checkbox"
                value=""
                id="flexCheckChecked"
                required
              ></input>
              <label className="form-check-label" htmlFor="flexCheckChecked">
                Agree with Terms Of Use
              </label>
            </div>
    
            
            <small className="text-white">
              It is necessary to agree to the Privacy Policy and Terms of Use.
            </small>
            </div>
          </form>    
        </div>

      </div>


    </div>
  );
}

export default Body;
