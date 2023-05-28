import React from 'react';
import { HeroContent } from './Helpers/renders/units/HeroContent';
import { Toast } from './Helpers/renders/fragments/Toast';
import { LiveData } from './Helpers/renders/fragments/LiveData';

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
    <div className="container col-xl-10 col-xl-10 px-5 py-4 mb-5">
      <div className="row align-items-center g-lg-6 py-3 mb-5">
          <HeroContent/>
        <div className="col-md-10 mx-auto col-lg-4 mb-4">
          <form className="p-4 p-md-4 card" onSubmit={handleSubmit}>
            <LiveData />
          </form>
          {toastContainer}   
        </div>

      </div>
    </div>
  );
}

