import React, { Component } from 'react';
import '../App.css';

class State extends Component {

    constructor( props ) {
        super( props );
        this.state = {counter: 0};
    }


    incrementCounter = () => {
        this.setState((prevState) => {
            return {counter: ++ prevState.counter};
        });
    };

    resetCounter = () => {
        this.setState( {counter: 0});
    };

    render() {
        return(
            <div className="App">
                <h2> Current state.counter is { this.state.counter }</h2>
                <button onClick= {this.incrementCounter }> Increment</button>
                <button onClick= {this.resetCounter }> Increment</button>
            </div>
        );
    }
}


class ComponentLifeCycle extends Component {

    constructor( props ) {
        super( props );
        this.state = {counter: 0};
    }

    componentDidMount = () => {
      this.timer = setInterval(this.incrementCounter, 1000);
    };


    componentDidUpdate (prevProps, prevState) {
        console.log ('I JUST UPDATED');
        if (prevState.counter == 50){
            this.setState ({ counter:0 });
        }
    }

    componentWillUnmount() {
        clearInterval(this.timer);
    }

    incrementCounter = () => {
        this.setState((prevState) => {
            return {counter: ++ prevState.counter};
        });
    };

    resetCounter = () => {
        this.setState( {counter: 0});
    };

    render() {
        return(
            <div className="App">
                <h2> Current state.counter is { this.state.counter }</h2>
            </div>
        );
    }
}


class UserData extends Component {

    constructor( props ) {
        super( props );

        this.state = {
            name: '',
            email: '',
            gender: ''
        };
    }

    handleInput = (event) => {
        this.setState ({[event.target.id]: event.target.value});
    };

    handleSubmit = (event) => {
        event.preventDefault();
        console.log(this.state);
    };

    render() {
        return(
            <div className="App" style={{ padding: 25}}>
                <form onSubmit={ this.handleSubmit }>
                    <input 
                        id='name'
                        value={ this.state.name}
                        onChange={ this.handleInput}
                        type='text'
                        placeholder='name'
                        autoComplete='off'
                    />
                    <input 
                        id='email'
                        value={ this.state.email}
                        onChange={ this.handleInput}
                        type='text'
                        placeholder='email'
                        autoComplete='off'
                    />
                    <br/>
                    <select 
                        id='gender'
                        value={ this.state.gender}
                        onChange={ this.handleInput}
                    >
                        <option value=''></option>
                        <option value='Male'></option>
                        <option value='Female'></option>
                    </select>
                    <br/>
                    <br/>
                    <input 
                        type='submit'
                        value='Confimr'
                    />
                </form>
                <hr/>
                <div style = {{textAlign: 'left'}}>
                    <p>
                        Name: <b>{this.state.name}</b>
                    </p>
                    <p>
                        Email: <b>{this.state.email}</b>
                    </p>
                    <p>
                        Gender: <b>{this.state.gender}</b>
                    </p>
                </div>
            </div>
        );
    }
}



class Arrays extends Component {

    constructor( props ) {
        super( props );
        this.state = {
            messages: [
                {author: 'Ivo', content: 'Hello'},
                {author: 'Mike', content: 'Hey, Whats up?'},
                {author: 'Ivo', content: 'Hey, Mike, How is Peter?'},
                {author: 'Peter', content: 'He is feeling good, what about you?'},
                {author: 'John', content: 'Fine as well, Thank you!'},
            ]


        };
    }

renderMessages(){
    const messageElements = this.state.messages.map( (messageObj , index) => {
        <p key={index}><b>{messageObj.author} :</b>{messageObj.content}</p>;

    });

    return messageElements;
}

    render() {
        return(
            <div className="App">
                {this.renderMessages()}
            </div>
        );
    }
}







class WebbAppPlanning extends Component {

    constructor( props ) {
        super( props );
        this.state = {
            messages: [
                {author: 'Ivo', content: 'Hello'},
                {author: 'Mike', content: 'Hey, Whats up?'},
                {author: 'Ivo', content: 'Hey, Mike, How is Peter?'},
                {author: 'Peter', content: 'He is feeling good, what about you?'},
                {author: 'John', content: 'Fine as well, Thank you!'},
            ]


        };
    }

renderMessages(){
    const messageElements = this.state.messages.map( (messageObj , index) => {
        <p key={index}><b>{messageObj.author} :</b>{messageObj.content}</p>;

    });

    return messageElements;
}

    render() {
        return(
            <div className="App">
                {this.renderMessages()}
            </div>
        );
    }
}