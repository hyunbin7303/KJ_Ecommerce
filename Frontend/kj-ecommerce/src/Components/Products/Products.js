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
  ProductQuantity,
  ProductImgContainer,
} from "./ProductsElements/ProductsElements";

import Currency from "react-currency-formatter-v2";

// this component will display products in a horizontal grid

const Products = (props) => {
  //let intPrice = parseFloat(props.ProductPrice);

  const quantity = null;

  let ProdQuantity = null;

  if (props.unitsInStock === "True") {
    ProdQuantity = (
      <ProductQuantity>
        <option value="" hidden>
          Select Quantity
        </option>
        <option value="1">1</option>
        <option value="2">2</option>
        <option value="3">3</option>
        <option value="4">4</option>
        <option value="5">5</option>
      </ProductQuantity>
    );
  }

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

            {/* If units in stock = true render this {ProdQuantity}*/}
            
            <ProductQuantity>
              <option value="" hidden>
                Select Quantity
              </option>
              <option value="1">1</option>
              <option value="2">2</option>
              <option value="3">3</option>
              <option value="4">4</option>
              <option value="5">5</option>
            </ProductQuantity>
          </ProductDiv>
        </Product>
        <AddToCart>Add to Cart</AddToCart>
      </ProductsList>
    </ProductsContainer>
  );
};

export default Products;
