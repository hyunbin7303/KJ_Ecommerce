import React from "react";
import { HomePageContainer, HomePageProductGrid } from "./HomePageElements/HomePageElements";
import ProductsView from "../../../Container/ProductsView/ProductsView";
import ReactAux from "../../../Hoc/ReactAux/ReactAux";

const HomePage = () => {
  return (
    <ReactAux>
      <HomePageContainer>
        {/* <Product /> */}
        <ProductsView />
      </HomePageContainer>
    </ReactAux>
  );
};

export default HomePage;
