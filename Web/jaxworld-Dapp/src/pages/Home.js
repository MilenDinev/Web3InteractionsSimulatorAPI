import { Component } from 'react';

export default class Home extends Component {

  constructor(props){
  super(props);
  document.title = this.props.title;
  }

  render(){
  return (
    <>
    <div className="container mbl-end-xl text-fonts text-l-space py-auto">
      <div className="row mx-auto text-color text-center">
        <label className="mx-auto bg-box-classic-an">
        <h1 className="txt-f-s-xl-b text-center my-auto px-3 py-2">Page Under Construction</h1>
        </label>     
      </div>
    </div>
    </>
  );
  }
}