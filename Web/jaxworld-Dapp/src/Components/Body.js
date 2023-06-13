import React from 'react';
import { HeroContent } from './renders/units/HeroContent';
import { Toast } from './renders/fragments/Toast';
import { LiveData } from './renders/fragments/LiveData';

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
    <div className="container col-xl-10 mb-sm-5 my-md-0 mb-lg-5 mb-xl-5 py-1 ">
      <div className="row align-items-center my-sm-1 my-md-0 my-lg-2 g-lg-4 py-3 mb-2">
          <HeroContent/>
        <div className="col-md-10 mx-auto col-lg-4 my-sm-1 my-md-3 my-lg-0 my-xl-5 card py-3">
          <form className="p-sm-0 p-md-2 p-lg-2 p-xl-2 mx-auto" onSubmit={handleSubmit}>
            <LiveData />
          </form>
          {toastContainer}   
        </div>

      </div>
    </div>
  );
}

