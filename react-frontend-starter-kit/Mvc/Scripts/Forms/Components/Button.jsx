import React, {Component} from 'react';
import power from '../../../Assets/Images/power-icon.svg';

var buttonStyle = {
  margin: '10px 10px 10px 0'
};

export default class Button extends Component {
  constructor(props) {
    super(props);
    this.handleClick = this.handleClick.bind(this);
  }

  handleClick(e) {
    alert('Hello');
    e.preventDefault();
  }

  render () {
    return (
      <button onClick={this.handleClick}
        className="btn btn-default"
        style={buttonStyle}>Button
        <img className="power-icon" src={power} width="40" alt="power icon"/>
      </button>
    );
  }
}
