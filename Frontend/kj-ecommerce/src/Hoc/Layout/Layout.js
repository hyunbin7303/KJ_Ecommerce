import React, { Component } from "react";
import ReactAux from "../ReactAux/ReactAux";
import styled from "styled-components";

export const MainContent = styled.main`
  margin-top: 72px;
`;

//The purpose of this component is to manage the layout of the application
class Layout extends Component {
  state = {};

  //SideDrawerClosedHandler

  //SideDrawerToggle

  render() {
    return (
      <ReactAux>
        {/* NavBar */}
        {/* SideDrawer */}
        <MainContent>
            {this.props.children}
        </MainContent>
        {/* Footer */}
      </ReactAux>
    );
  }
}

export default Layout;