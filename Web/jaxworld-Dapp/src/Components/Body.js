import React from 'react';
import { Claim } from './Helpers/renders/units/Claim';
import { ContractData } from './Helpers/renders/units/ContractData';
import HeroContent from './Helpers/renders/units/HeroContent';

export function Body() {



  return (
      <>
      <BodyContent/>
      </>   
  );
}


function BodyContent() {

  
  const handleSubmit = event => {
    console.log('handleSubmit ran');
    event.preventDefault();


  };
  return (
    <div className="container col-xl-10 col-xxl-8 px-4 py-5">
      <div className="row align-items-center g-lg-5 py-5">
          <HeroContent/>
        <div className="col-md-10 mx-auto col-lg-5">
          <form className="p-4 p-md-5 border border-secondary border-opacity-50 rounded-5 bg-transparent" onSubmit={handleSubmit}>
            <ContractData />
            <Claim />
          </form>    
        </div>

      </div>


    </div>
  );
}

