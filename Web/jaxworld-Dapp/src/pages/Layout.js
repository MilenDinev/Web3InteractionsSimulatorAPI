import { Outlet } from 'react-router-dom';
import { Header } from '../mint-event-src/main/Header';
import { Footer } from '../mint-event-src/main/Footer';
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