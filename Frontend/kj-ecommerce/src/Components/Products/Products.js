import React from "react";
import {
  ProductsContainer,
  ProductsList,
  Product,
  ProductName,
  ProductDescription,
  ProductPrice,
  ProductImg,
} from "./ProductsElements/ProductsElements";

// this component will display products in a horizontal grid

const Products = (props) => {
  return (
    <ProductsContainer>
      <ProductsList>
        <Product>
          <ProductName>
            {/* a href */}
            {props.ProductName}
          </ProductName>
          <ProductImg src="https://hpecommerce.blob.core.windows.net/kp-container/lord_of_the_ring_TheFellowshipOfTheRing.jpg" />
          <ProductDescription>{props.ProductDescription}</ProductDescription>
          <ProductPrice>{props.ProductPrice}</ProductPrice>
        </Product>
      </ProductsList>
    </ProductsContainer>
  );
};

export default Products;
