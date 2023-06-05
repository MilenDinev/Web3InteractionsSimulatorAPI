export default function Contact() {
  return (
    <>
    <div className="container contact-form-main">
      <div className="row contact-form-main text">
        <label>
        <p>Please use these channels to contact us:</p>
        </label>     
      </div>
    </div>
    <div className="container contact-form">
    <div className="row contact-form text">
        <div>
        <a target="_blank" rel="noreferrer" href=" mailto: support@jaxworld.xyz" data-toggle="tooltip" title="Email us">Email us</a>
        </div>     
      </div>
      <div className="row contact-form text">
        <div>
        <a target="_blank" rel="noreferrer" data-toggle="tooltip" title="Twitter" href="https://twitter.com/jaxworld_">Twitter</a>
        </div>     
      </div>
      <div className="row contact-form text">
        <div>
        <a target="_blank" rel="noreferrer" data-toggle="tooltip" title="Discord" href="https://discord.com/invite/dPNE6fK4S4">Discord</a>
        </div>     
      </div>
      </div>
    </>
  );
}