import React, { Component } from 'react';
import './App.css';

class App extends Component {
    constructor(props) {
      super(props);
      this.state = {
        players: [],
        isLoaded: false,
      }
    }

    componentDidMount() {
      fetch('https://www.balldontlie.io/api/v1/players/1043')
        .then(result => result.json())
        .then(json => {
            this.setState({
              isLoaded: true,
              players: json,
            })
        });
    }

    render() {

      var { isLoaded, players } = this.state;

      if(!isLoaded) {
        return <div>Loading...</div>;
      }
      else {
          return (
            <div className="App">
                {players.first_name} {players.last_name}
            </div>
        );
      }
    }
}

export default App;
