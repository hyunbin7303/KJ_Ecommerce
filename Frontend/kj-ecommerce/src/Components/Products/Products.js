import React from "react";
import {
  GridArea,
  GridContainer,
  Content,
  ProductsContainer,
  ProductsList,
  Product,
  ProductName,
  ProductDescription,
  ProductPrice,
} from "./ProductsElements/ProductsElements";

// this component will display products in a horizontal grid

const Products = (props) => {
  return (
    <GridArea>
      <GridContainer>
        <Content>
          <ProductsContainer>
            <ProductsList>
              <Product>
                {/* img element */}
                <ProductName>{/* a href */}{props.ProductName}</ProductName>
                <ProductDescription>{props.ProductDescription}</ProductDescription>
                <ProductPrice>{props.ProductPrice}</ProductPrice>
              </Product>
            </ProductsList>
          </ProductsContainer>
        </Content>
      </GridContainer>
    </GridArea>
  );
};

export default Products;
