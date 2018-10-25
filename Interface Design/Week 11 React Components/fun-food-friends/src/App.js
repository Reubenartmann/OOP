import React, { Component } from 'react';
//import logo from './logo.svg';
import './App.css';

import firebase from './firebase.js';


class App extends Component {

  constructor() {
    super();
    this.state = {
      username: '',
      currentItem: '',
      glutenFree: '',
      items: []
    }
    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleSubmit(e) {
    e.preventDefault();
    const itemsRef = firebase.database().ref('items');
    const item = {
      title: this.state.currentItem,
      user: this.state.username,
      gf: this.state.glutenFree
    }

    itemsRef.push(item);

    this.setState({
      currentItem: '',
      username: '',
      glutenFree: ''
    });
  }

  handleChange(e) {
  this.setState({
    [e.target.name]: e.target.value
  });
}

removeItem(itemId) {
  const itemRef = firebase.database().ref(`/items/${itemId}`);
  itemRef.remove();
}

modifyItem(itemId) {

  const itemRef = firebase.database().ref(`/items/${itemId}`);

  itemRef.update();
}

componentDidMount() {
  const itemsRef = firebase.database().ref('items');
  itemsRef.on('value', (snapshot) => {
    let items = snapshot.val();
    let newState = [];
    for (let item in items) {
      newState.push({
        id: item,
        title: items[item].title,
        user: items[item].user,
        gf: items[item].gf
      });
    }
    this.setState({
      items: newState
    });
  });
}

  render() {
    return (
      <div className='app'>
        <header>
            <div className='wrapper'>

              <h1>Fun Food Friends</h1>

            </div>
        </header>
        <div className='container'>
          <section className='add-item'>
              <form onSubmit={this.handleSubmit}>
                <input type="text" name="username" placeholder="What's your name?" onChange={this.handleChange} value={this.state.username} />
                <input type="text" name="currentItem" placeholder="What are you bringing ?" onChange={this.handleChange} value={this.state.currentItem} />
                <input type="text" name="glutenFree" placeholder="Is it gluten free ?" onChange={this.handleChange} value={this.state.glutenFree} />
                <button>Add Item</button>
              </form>
          </section>
          <section className='display-item'>
            <div className="wrapper">
              <ul>
                {this.state.items.map((item) => {
                  return (
                    <li key={item.id}>
                      <h3>{item.title}</h3>
                      <p>brought by: {item.user}</p>
                      <p>gluten free: {item.gf}</p>
                      <button className='removeItem' onClick={() => this.removeItem(item.id)}>Remove Item</button>
                      <button className='modifyItem' onClick={() => this.modifyItem(item.id)}>Modify Item</button>
                    </li>
                  )
                })}
              </ul>
            </div>
          </section>
        </div>
      </div>
    );
  }
}
export default App;