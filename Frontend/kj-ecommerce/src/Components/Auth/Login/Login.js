import React, { Component } from "react";
import ReactAux from "../../../Hoc/ReactAux/ReactAux";
import { LoginWrapper } from "./LoginElements/LoginElements";
import axios from "axios";

export default class Login extends Component {
  constructor(props) {
    super(props);

    this.state = {
      Username: "",
      password: "",
      loginErrors: "",
    };

    this.handleSubmit = this.handleSubmit.bind(this);
    this.handleChange = this.handleChange.bind(this);
  }

  /* The purpose of this function is to handle the change in the form fields and update them */
  handleChange(event) {
    this.setState({
      [event.target.name]: event.target.value,
    });
  }

  handleSubmit(event) {
    const { username, password } = this.state;

    axios
      .post("http://localhost:59575/identity/login", {
        Username: username,
        password: password,
      })
      .then((response) => {
        console.log("USER Logged In: " + response.data);
      })
      .catch((error) => {
        console.log("Login Error: ", error);
      });
    event.preventDefault();
  }

  render() {
    return (
      <ReactAux>
        <LoginWrapper>
          <form>
            <label>
              <p>Username</p>
              <input
                type="text"
                placeholder="Username"
                value={this.state.Username}
                onChange={this.handleChange}
                required
              />
            </label>
            <label>
              <p>Password</p>
              <input type="password" placeholder="Password" value={this.state.password} onChange={this.handleChange} required />
            </label>
            <div>
              <button type="submit">Login</button>
            </div>
          </form>
        </LoginWrapper>
      </ReactAux>
    );
  }
}
