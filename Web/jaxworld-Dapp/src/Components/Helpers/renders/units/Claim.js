import {Web3Button} from '@thirdweb-dev/react';
import React from 'react';
import 'react-toastify/dist/ReactToastify.css';
import { GetToast } from '../fragments/Toast';

export function Claim() {

  const {toastContainer, submit, success, error} = GetToast();

  return (
<>
    <div className="d-flex justify-content-center">

    <Web3Button
      dropdownPosition={{ side: 'bottom', align: 'center' }}
      contractAddress="0x7e327E167FD7a339e410dd34f17e2856388e0a9a"
      action={(contract) => contract.erc721.claim(1)}
      onSuccess={success}
      onSubmit= {submit}
      onError={error}
      // Logic to execute when clicked
    >
      Claim NFT
    </Web3Button>

    {toastContainer}
    
    </div>

  <hr className="my-4"></hr>
  <div className="form-control border-0 bg-secondary bg-gradient rounded-4 p-2 text-muted bg-opacity-10 form-floating mb-3">
    <div className="form-check text-opacity-75">
      <input
        className="form-check-input"
        type="checkbox"
        id="flexCheckChecked"
        required
      >                  
      </input>
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
  </>
  );
}