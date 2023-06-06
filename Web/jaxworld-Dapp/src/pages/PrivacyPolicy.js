import { Component } from 'react';

export default class PrivacyPolicy extends Component {
    constructor(props){
      super(props);
      document.title = this.props.title;
    }
  
  render(){
  return (
    <>
      <div className="container policies-screen">
        <div className="row policies-screen text">
          <label>
            <p>Privacy Policy for Jax World</p>
            <p>Effective Date: 06.01.2023 </p>
            <p>
              Welcome to Jax World, a blockchain-based NFT gaming platform. We
              respect your privacy and are committed to protecting it. This
              Privacy Policy explains how we collect, use, and disclose
              information about you when you access or use our platform.
            </p>
            <p>
              We may update this Privacy Policy from time to time. If we make
              any material changes, we will notify you by posting the updated
              Privacy Policy on our platform or by sending you an email.
            </p>
            <ul>
              <li>
                <h5>Information We Collect</h5>
                <ul>
                  {" "}
                  We collect information you provide to us when you register for
                  an account, participate in our games, or otherwise use our
                  platform. The information we collect may include:
                  <li>
                    Your name, email address, and other contact information
                  </li>
                  <li>Your username and password</li>
                  <li>Your blockchain wallet address</li>
                  <li>Your game preferences and gameplay data</li>
                  <li>
                    Your device information, such as your IP address, browser
                    type, and operating system
                  </li>
                  <li>Other information you choose to provide to us</li>
                </ul>
              </li>
              <li>
                <br />
                <h5>How We Use Your Information</h5>
                <ul>
                  We may use the information we collect for the following
                  purposes:
                  <li>To provide and improve our platform and services</li>
                  <li>To personalize your experience on our platform</li>
                  <li>
                    To communicate with you about our platform, including
                    updates and promotions
                  </li>
                  <li>To process transactions and verify your identity</li>
                  <li>
                    To prevent fraud and unauthorized access to your account
                  </li>
                  <li>To comply with legal obligations</li>
                </ul>
              </li>
              <li>
                <br />
                <h5>How We Share Your Information</h5>
                <ul>
                  <li>
                    We may share your information with third-party service
                    providers that help us operate our platform and provide our
                    services, such as payment processors, analytics providers,
                    and marketing partners.
                  </li>
                  <li>
                    We may also share your information with other users of our
                    platform if you participate in multiplayer games.
                  </li>
                  <li>
                    We may disclose your information if required by law or if we
                    believe that such disclosure is necessary to protect our
                    rights or the rights of others, investigate fraud or other
                    illegal activity, or respond to a government request.
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <h5>Your Choices</h5>
                <ul>
                  <li>
                    You can choose not to provide certain information to us, but
                    this may limit your ability to use our platform and
                    services.
                  </li>
                  <li>
                    You can also opt-out of receiving promotional emails from us
                    by following the instructions in the email. Even if you
                    opt-out, we may still send you non-promotional messages,
                    such as updates about your account or our platform.
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <h5>Security</h5>
                <ul>
                  <li>
                    We take reasonable measures to protect the information we
                    collect from unauthorized access, disclosure, or
                    destruction. However, no security system is perfect, and we
                    cannot guarantee the security of your information.
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <h5>Children's Privacy</h5>

                <ul>
                  <li>
                    Our platform is not intended for children under the age of
                    16. We do not knowingly collect personal information from
                    children under 16. If we learn that we have collected
                    personal information from a child under 13, we will delete
                    it as soon as possible.
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <h5>International Data Transfers</h5>
                <ul>
                  <li>
                    Your information may be transferred to and processed in
                    countries other than the country where you are located.
                    These countries may have different data protection laws than
                    your country of residence. By using our platform, you
                    consent to the transfer of your information to these
                    countries.
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <h5>SUPPLEMENTARY TERMS - CALIFORNIA</h5>
                <p>
                  This privacy notice section for California residents
                  supplements the information contained in Our Privacy Policy
                  and it applies solely to all visitors, users, and others who
                  reside in the State of California, unless otherwise stated
                  that it applies to United States residents generally.
                </p>
                <ul>
                  <li>Personal Information for the purpose of the California Consumer Privacy Act (CCPA) means any information that identifies, relates to, describes or is capable of being associated with, or could reasonably be linked, directly or indirectly, with You. Under CCPA, personal information does not include: Publicly available information from government records, deidentified or aggregated consumer information, information excluded from the CCPA’s scope, such as health or medical information covered by the Health Insurance Portability and Accountability Act of 1996 (HIPAA) and the California Confidentiality of Medical Information Act (CMIA) or clinical trial data Personal Information covered by certain sector-specific privacy laws, including the Fair Credit Reporting Act (FRCA), the Gramm-Leach-Bliley Act (GLBA) or California Financial Information Privacy Act (FIPA), and the Driver’s Privacy Protection Act of 1994.</li>
                  <li>Business for the purpose of the CCPA refers to the Jax World (or in this case the Jax World Data Representative)as the legal entity that collects Consumers’ Personal Information and determines the purposes and means of the processing of Consumers’ Personal Information, or on behalf of which such information is collected and that alone, or jointly with others, determines the purposes and means of the processing of consumers’ Personal Information, that does business in the State of California.</li>
                  <li>Consumer for the purpose of the CCPA means a natural person who is a California resident. A resident, as defined in the law, includes (1) every individual who is in California for other than a temporary or transitory purpose, and (2) every individual who is domiciled in the California who is outside California for a temporary or transitory purpose.</li>
                  <li>Do Not Track (DNT) is a concept that has been promoted by US regulatory authorities, in particular the U.S. Federal Trade Commission (FTC), for the Internet industry to develop and implement a mechanism for allowing internet users to control the tracking of their online activities across websites. Provisions regarding Do Not Track references herein apply to all residents of the United States</li>
                  <li>Sale, for the purpose of the CCPA (California Consumer Privacy Act), means selling, renting, releasing, disclosing, disseminating, making available, transferring, or otherwise communicating orally, in writing, or by electronic or other means, a Consumer’s personal information to another business or a third party for monetary or other valuable consideration.</li>
                </ul>
              </li>
              <li>
                <br />
                <h5>Your California Privacy Rights</h5>
                <ul>
                  <li>
                    Under California Civil Code Section 1798 (California’s Shine
                    the Light law), California residents with an established
                    business relationship with us can request information once a
                    year about sharing their Personal Data with third parties
                    for the third parties’ direct marketing purposes. If you’d
                    like to request more information under the California Shine
                    the Light law, and if You are a California resident, You can
                    contact Us using the contact information provided below.
                  </li>
                  <li>
                    California Privacy Rights for Minor Users (California
                    Business and Professions Code Section 22581): California
                    Business and Professions Code section 22581 allows
                    California residents under the age of 18 who are registered
                    users of online sites, services or applications to request
                    and obtain removal of content or information they have
                    publicly posted. To request removal of such data, and if You
                    are a California resident, You can contact Us using the
                    contact information provided below, and include the email
                    address associated with Your account. Be aware that Your
                    request does not guarantee complete or comprehensive removal
                    of content or information posted online and that the law may
                    not permit or require removal in certain circumstances
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <h5>Contact Us</h5>
                <ul>
                  <li>
                    If you have any questions or concerns about this Privacy
                    Policy, please contact us at support@jaxworld.xyz .
                  </li>
                </ul>
              </li>
              <li>
                <br />
                <p>Acceptance of Terms</p>
                <p>
                  By using our platform, you consent to this Privacy Policy and
                  our Terms of Use.
                </p>
              </li>
            </ul>
            <p>Thank you for choosing Jax World!</p>
            <br />
          </label>
        </div>
      </div>
    </>
  );
  }
}