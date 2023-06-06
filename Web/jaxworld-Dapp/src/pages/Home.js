import { Component } from 'react';

export default class Home extends Component {

  constructor(props){
  super(props);
  document.title = this.props.title;
  }

  render(){
  return (
    <>
    <div className="container welcome-screen">
      <div className="row welcome-screen text">
        <label>
        <p>Page Under Construction</p>
        </label>     
      </div>
    </div>
    </>
  );
  }
}