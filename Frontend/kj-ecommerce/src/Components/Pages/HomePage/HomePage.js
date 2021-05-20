import React from "react";
import { HomePageContainer } from "./HomePageElements/HomePageElements";
import ProductsView from "../../../Container/ProductsView/ProductsView";
import ReactAux from "../../../Hoc/ReactAux/ReactAux";

const HomePage = () => {
  return (
    <ReactAux>
      <HomePageContainer>
        <div className="h1">KJ Ecommerce</div>
        {/*<List />
        <Product /> */}
        <ProductsView />
      </HomePageContainer>
    </ReactAux>
  );
};

export default HomePage;
