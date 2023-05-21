import { getRandomNumber } from './utils';
import { getRandomColor } from './utils';

export  function registerTicket() {
    const newTicket = {
        number : getRandomNumber(),
        color : getRandomColor()
    };


    this.setState( (prevState) => {
        prevState.tickets.push ( newTicket);

        return {
            tickets: prevState.tickets,
            remainingTickets : -- prevState.remainingTickets
        };
    } );
}