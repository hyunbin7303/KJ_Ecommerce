import React, { Component } from "react";
import "./App.css";
import HomePage from "./Components/Pages/HomePage/HomePage";
import ReactAux from "./Hoc/ReactAux/ReactAux";
import Layout from "./Hoc/Layout/Layout";
import { Route, Switch } from "react-router-dom";
import CheckoutPage from "./Components/Pages/CheckoutPage/CheckoutPage";
import OrderPage from "./Components/Pages/OrderPage/OrderPage";
import axios from 'axios';

export default class App extends Component {
  constructor() {
    super();

    this.state = {
      loggedInStatus: "NOT_LOGGED_IN",
      user: {},
    };

    this.handleLogin = this.handleLogin.bind(this);
    this.handleLogout = this.handleLogout.bind(this);
  }

  // check login status
  checkLoginStatus() {
    //axios.get("") ** add check login api method 

  }


  render() {
    return (
      <ReactAux>
        <Layout>
          <Switch>
            <Route path="/checkout" component={CheckoutPage} />
            <Route path="/orders" component={OrderPage} />
            <Route path="/home" exact component={HomePage} />
          </Switch>
        </Layout>
      </ReactAux>
    );
  }
}
