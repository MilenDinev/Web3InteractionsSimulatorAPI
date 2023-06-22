import { Component } from "react";

export default class Contact extends Component {
  constructor(props) {
    super(props);
    document.title = this.props.title;
  }

  render() {
    return (
      <>
        <div className="container mrg-t-lg-10 wth-un d-flex op-xl text-clr-lg">
          <div className="custom-box-h wth-lg-10 mrg-ac mrg-t-lg-10 wth-un row op-xl mrg-be-lg-5 font-size-m-br">
            <label>
              <p className="mrg-t-lg-4 text-clr-lg text-fonts text-ac">
                Please use these channels to contact us:
              </p>
            </label>
          </div>
        </div>
        <div className="container mrg-be-lg-6 d-flex text-ac text-fonts text-clr-lg">
          <div className="row custom-box-h mrg-ac text wth-lg-6 mrg-be-lg-10 mrg-t-lg-10 contact-form">
            <div>
              <a
                className="text-dec-n text-clr-lg font-size-m-br"
                target="_blank"
                rel="noreferrer"
                href=" mailto: support@jaxworld.xyz"
                data-toggle="tooltip"
                title="Email us"
              >
                Email us
              </a>
            </div>
          </div>
          <div className="row custom-box-h text mrg-ac wth-lg-6 mrg-be-lg-10  mrg-t-lg-10 contact-form">
            <div>
              <a
                className="text-dec-n text-clr-lg font-size-m-br"
                target="_blank"
                rel="noreferrer"
                data-toggle="tooltip"
                title="Twitter"
                href="https://twitter.com/jaxworld_"
              >
                Twitter
              </a>
            </div>
          </div>
          <div className="row custom-box-h text mrg-ac wth-lg-6 mrg-be-lg-10 mrg-t-lg-10 contact-form">
            <div>
              <a
                className="text-dec-n text-clr-lg font-size-m-br"
                target="_blank"
                rel="noreferrer"
                data-toggle="tooltip"
                title="Discord"
                href="https://discord.com/invite/dPNE6fK4S4"
              >
                Discord
              </a>
            </div>
          </div>
        </div>
      </>
    );
  }
}
