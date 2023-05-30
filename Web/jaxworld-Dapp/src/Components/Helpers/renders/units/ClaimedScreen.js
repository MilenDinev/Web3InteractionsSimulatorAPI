import { ThirdwebNftMedia, useContract, useNFT } from '@thirdweb-dev/react';

import '../../../../styles/welcome-screen.css';
export function ClaimedScreen() {

  // Connect to your NFT contract
  const { contract } = useContract('0x7e327E167FD7a339e410dd34f17e2856388e0a9a');
  // Load the NFT metadata from the contract using a hook
  const { data: nft, isLoading, error } = useNFT(contract, '0');

  // Render the NFT onto the UI
  if (isLoading) {

    return <div>Loading...</div>;

  }



  if (error || !nft){

    return <div>NFT not found</div>;
  }
  


  return (
    <ThirdwebNftMedia
      metadata={nft.metadata}
      controls={true}
    />
  );

}
