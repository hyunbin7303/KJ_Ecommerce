import React from "react";
import List from "../../List/List";
import { HomePageContainer } from "./HomePageElements/HomePageElements";
import Product from "../../Product/Product";

const HomePage = () => {
  return (
    <div>
      <HomePageContainer>
        <List />
        <Product />
      </HomePageContainer>
    </div>
  );
};

export default HomePage;
