import React from "react";
import List from "../../List/List";
import { HomePageContainer } from "./HomePageElements/HomePageElements";
import Product from "../../Product/Product";
import Products from "../../Products/Products";

const HomePage = () => {
  return (
    <div>
      <HomePageContainer>
        {/*<List />
        <Product /> */}
        <Products
          ProductName="Prod 1"
          ProductDescription="Prod 1 Description"
          ProductPrice="123"
        />

        <Products
          ProductName="Prod 2"
          ProductDescription="Prod 2 Description"
          ProductPrice="123"
        />

        <Products
          ProductName="Prod 3"
          ProductDescription="Prod 3 Description"
          ProductPrice="123"
        />

      </HomePageContainer>
    </div>
  );
};

export default HomePage;
