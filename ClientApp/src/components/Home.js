import React, { Component } from 'react';
import axios from "axios";

export class Home extends Component {
  static displayName = Home.name;
  constructor(props) {
      super(props);
      this.state = {users:[]}
  }
  
  componentDidMount() {
    debugger
      axios.get("http://5iaf6t.realhost-free.net/api/User")
          .then(response => {
            this.setState({users: response.data})
              
            debugger
          })
      
  }
  componentDidUpdate(prevProps, prevState, snapshot) {
      console.log(this.state)
      
  }

    render() {
    return (
      <div>
          {this.state.users.length===0? 'nothing': this.state.users.map(u=> {
              debugger
              return (<div>
              <div>Firs Name: {u.firstName}</div>
              <div>Last Name: {u.lastName}</div>
              <div>User Id: {u.id}</div>
              <div>User Emale: {u.email}</div>
                  </div>
          )
          })}
      </div>
    );
  }
}
