import {Web3Button} from "@thirdweb-dev/react";

function Mint() {
    
  return (
    <div className="d-flex justify-content-center">
    <Web3Button
      dropdownPosition={{ side: "bottom", align: "center" }}
      auth={{ loginOptional: false }}
      contractAddress="0x1426ba92E4091b41d3923A946CC5032F2878aC9F"
      // For example, claim an NFT from this contract when the button is clicked
      action={(contract) => contract.erc721.claim(1)}
      // Logic to execute when clicked
    >
      Claim NFT
    </Web3Button>
    </div>
  );
}
export default Mint;