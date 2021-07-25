import React, { useState } from "react";
import ReactAux from "../../../Hoc/ReactAux/ReactAux";
import { LoginWrapper } from "./LoginElements/LoginElements";
import PropTypes from "prop-types";
import axios from "axios";
import { useHistory } from 'react-router-dom';

async function userLogin(userName, userPassword) {
  console.log(userName + userPassword);
  return axios
    .post(
      "http://localhost:59575/identity/login",
      {
        username: userName,
        password: userPassword,
      },
      {
        headers: {
          "Content-Type": "application/json; charset=UTF-8",
        },
      }
    )
    .then((response) => {
      console.log("USER Logged In Token: " + response.data.token);
    })
    .catch((error) => {
      console.log("Login Error: ", error);
    });
}

export default function Login({ setToken }) {
  const history = useHistory();
  const [username, setUserName] = useState();
  const [password, setPassword] = useState();

  const handleSubmit = async (e) => {
    e.preventDefault();
    const token = await userLogin(username, password);
    setToken(token);
    console.log("Token set");
    console.log(history);
    history.push("/home");
  };

  return (
    <ReactAux>
      <LoginWrapper>
        <form onSubmit={handleSubmit}>
          <label>
            <p>Username</p>
            <input
              type="text"
              placeholder="Username"
              onChange={(e) => setUserName(e.target.value)}
              required
            />
          </label>
          <label>
            <p>Password</p>
            <input
              type="password"
              placeholder="Password"
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </label>
          <div>
            <button type="submit">Login</button>
          </div>
        </form>
      </LoginWrapper>
    </ReactAux>
  );
}

Login.propTypes = {
  setToken: PropTypes.func.isRequired,
};
