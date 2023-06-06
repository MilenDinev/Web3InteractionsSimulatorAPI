import { Outlet } from "react-router-dom";
import { Header } from "../Components/Header";
import { Footer } from "../Components/Footer";
import { Component } from 'react';

export default class Layout extends Component {
  constructor(props){
    super(props);
    document.title = this.props.title;
  }
  render(){
    return (
      <>
        <Header/>
  
        <Outlet />
  
        <Footer/>
      </>
    );
  }
}