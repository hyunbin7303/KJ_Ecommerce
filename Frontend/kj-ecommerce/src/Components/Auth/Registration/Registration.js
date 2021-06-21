import React, { Component } from "react";
import ReactAux from "../../../Hoc/ReactAux/ReactAux";
import { LoginWrapper } from "./LoginElements/LoginElements";

export default class Registration extends Component {
  render() {
    return (
      <ReactAux>
        <LoginWrapper>
          <form>
            <label>
              <p>Username</p>
              <input type="text" />
            </label>
            <label>
              <p>Password</p>
              <input type="password" />
            </label>
            <div>
              <button type="submit">Submit</button>
            </div>
          </form>
        </LoginWrapper>
      </ReactAux>
    );
  }
}
