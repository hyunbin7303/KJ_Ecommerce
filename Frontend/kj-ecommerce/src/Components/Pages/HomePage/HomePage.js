import React from "react";
import { HomePageContainer } from "./HomePageElements/HomePageElements";
import ProductsView from "../../../Container/ProductsView/ProductsView";
import ReactAux from "../../../Hoc/ReactAux/ReactAux";
import { Redirect } from "react-router-dom";

function HomePage({ authorized }) {
  if (!authorized) {
    return <Redirect to="/login"/>;
  }

  return (
    <ReactAux>
      <HomePageContainer>
        {/* <Product /> */}
        <ProductsView />
      </HomePageContainer>
    </ReactAux>
  );
}

export default HomePage;
