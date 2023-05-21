import React, { Component } from 'react';
import { getRandomNumber } from './Components/Helper/utils';
import { registerTicket } from './Components/Helper/Actions';
import Lottery from './Components/Lottery';
import './App.css';

class App extends Component {

    constructor( props ) {
        super( props );
        this.state = {
            winningNumber: getRandomNumber(),
            tickets : [],
            remainingTickets : 5,
            finished : false
        
        };

        this.registerTicket = registerTicket.bind (this);
    }

    renderApp() {
        const {tickets, remainingTickets} = this.state;
        const actions = {};

        actions.this.registerTicket = this.registerTicket;



        return (
            <Lottery
                actions = { actions }
                tickets = {tickets}
                remainingTickets = {remainingTickets}
            />

        );
    }

    render() {
        return(
            <div className='App'>
                { this.renderApp() }
            </div>
        );
    }
}


export default App;