import {Web3Button} from '@thirdweb-dev/react';
import React from 'react';
import { ToastContainer, toast } from 'react-toastify';

import 'react-toastify/dist/ReactToastify.css';

export function Claim() {

      const submit = () => toast.info('Transaction submitted!', {
        position: 'bottom-center',
        autoClose: 2000,
        hideProgressBar: true,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: 0,
        theme: 'light',
      });

      const success = () => toast.success('Successfully claimed!', {
        position: 'bottom-center',
        autoClose: 3000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: undefined,
        theme: 'light',
      });
    
      const error = () => toast.error('An error occured!', {
        position: 'bottom-center',
        autoClose: 5000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: undefined,
        theme: 'light',
      });
  return (

    <div className="d-flex justify-content-center">
    <Web3Button
      dropdownPosition={{ side: 'bottom', align: 'center' }}
      contractAddress="0x7e327E167FD7a339e410dd34f17e2856388e0a9a"
      // For example, claim an NFT from this contract when the button is clicked
      action={(contract) => contract.erc721.claim(1)}
      onSuccess={success}
      onError={error}
      onSubmit= {submit}
      // Logic to execute when clicked
    >
      Claim NFT
    </Web3Button>
    <ToastContainer 
    
    position="bottom-center"
    autoClose={5000}
    hideProgressBar={false}
    newestOnTop={false}
    closeOnClick
    rtl={false}
    pauseOnFocusLoss
    draggable
    pauseOnHover
    theme="light"
    />
    </div>
  );
}