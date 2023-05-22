import {Web3Button} from "@thirdweb-dev/react";

function Mint() {
    
  return (
    <div className="d-flex justify-content-center">
    <Web3Button
      dropdownPosition={{ side: "bottom", align: "center" }}
      auth={{ loginOptional: false }}
      contractAddress="0x7e327E167FD7a339e410dd34f17e2856388e0a9a"
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