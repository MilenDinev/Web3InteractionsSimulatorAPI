import React from "react";
import { Claim } from "./Helpers/renders/units/Claim";
import { ContractData } from "./Helpers/renders/units/ContractData";
import { HeroContent } from "./Helpers/renders/units/HeroContent";

export function Body() {



  return (
      <>
      <BodyContent/>
      </>   
  );
}


function BodyContent() {


  const handleSubmit = event => {
    event.preventDefault();


  };
  return (
    <div className="container col-xl-10 col-xxl-8 px-4 py-5">
      <div className="row align-items-center g-lg-5 py-5">
          <HeroContent/>
        <div className="col-md-10 mx-auto col-lg-5">
          <form className="p-4 p-md-5 " onSubmit={handleSubmit}>
            <div className="card">
            <ContractData />
            </div>
            <svg className="filter">
          <filter id="wavy2">
            <feTurbulence
              x="0"
              y="0"
              baseFrequency="0.02"
              numOctaves="5"
              seed="1"
            ></feTurbulence>
            <feDisplacementMap in="SourceGraphic" scale="20"></feDisplacementMap>
          </filter>
        </svg>
            <Claim />
          </form>    
        </div>

      </div>
    </div>
  );
}

