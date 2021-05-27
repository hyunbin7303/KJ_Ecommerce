import React from "react";
import {
  ProductsContainer,
  ProductsList,
  ProductDiv,
  Product,
  ProductName,
  ProductDescription,
  ProductPrice,
  ProductImg,
  AddToCart,
  ProductImgContainer,
} from "./ProductsElements/ProductsElements";

import Currency from "react-currency-formatter-v2";

// this component will display products in a horizontal grid

const Products = (props) => {
  let intPrice = parseFloat(props.ProductPrice);

  return (
    <ProductsContainer>
      <ProductsList>
        <Product>
          <ProductImgContainer>
            <ProductImg src="https://hpecommerce.blob.core.windows.net/kp-container/lord_of_the_ring_TheFellowshipOfTheRing.jpg" />
          </ProductImgContainer>
          <ProductDiv>
            <ProductName>
              {/* a href */}
              {props.ProductName}
            </ProductName>
            <ProductDescription>{props.ProductDescription}</ProductDescription>
            <ProductPrice>
              {/*<Currency quantity={props.ProductPrice} currency="CAD" /> CONVERT TO INT IN DB*/}
              {props.ProductPrice}
            </ProductPrice>
          </ProductDiv>
        </Product>
        <AddToCart>Add to Cart</AddToCart>
      </ProductsList>
    </ProductsContainer>
  );
};

export default Products;
