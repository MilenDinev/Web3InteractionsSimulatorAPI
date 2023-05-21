import React, { Component } from 'react';
import LotteryTicket from './LotteryTicket';

class Lottery extends Component {

    renderButton () {

        const  {remainingTickets, actions } = this.props;

        if (remainingTickets > 0) {
            return <button onClick={ actions.registerTicket} > Buy a ticket</button>;
        }
    }

    renderTickets() {
        const lotteryTickets = this.props.tickets.map( ( ticket, index) => {
            return (
                <LotteryTicket
                    color = {ticket.color}
                    number = {ticket.number}
                    index = {index}
                    key = {index}
                />

            );
        });

        return lotteryTickets;
    }

    render() {
        return(
            <>
            <h2>Lottery</h2>
            {this.renderButton()}
            <br/>
            <small>Tickets left: {this.props.remainingTickets}</small>
            <br/>
            <hr/>
            </>
        );
    }
}


export default Lottery;