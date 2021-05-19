import React from "react";
import { HomePageContainer } from "./HomePageElements/HomePageElements";
import ProductsView from "../../../Container/ProductsView/ProductView";

const HomePage = () => {
  return (
    <div>
      <HomePageContainer>
        {/*<List />
        <Product /> */}
        <ProductsView />

      </HomePageContainer>
    </div>
  );
};

export default HomePage;
