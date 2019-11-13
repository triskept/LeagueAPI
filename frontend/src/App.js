import React, { Component } from 'react';
import axios from 'axios';
import './App.css';

class App extends Component {
async componentDidMount() {
  const res = await axios.get('insert local host address here').then(res => console.log)
}

  render() {
    return (
      <div className="App">
        <h1>hello from react</h1>
      </div>
    );
  }
}

export default App;
