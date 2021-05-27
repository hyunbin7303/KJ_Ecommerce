import styled from "styled-components";

export const ProductsContainer = styled.ul`
  display: flex;
  position: relative;
  flex-direction: column;
  margin: 1.25rem;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
  background-color: #fff;
  z-index: 30;
  padding: 2.4rem;
`;

export const ProductsList = styled.li`
  list-style-type: none;
  padding: 0;
  flex: 0 1 34rem;
  margin: 1rem;
  height: 50rem;
`;

export const ProductDiv = styled.div`
  margin-bottom: 1.25rem;
`;

export const Product = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  height: 100%;
`;

export const ProductImgContainer = styled.div`
  display: flex;
  align-items: center;
  margin-right: calc(0.5rem * var(0));
  margin-left: calc(0.5rem * calc(1 - var(0)));
`;

export const ProductImg = styled.img`
  max-height: 34rem;
  max-width: 34rem;
`;

export const ProductName = styled.h4`
  font-size: 1.5rem;
  margin-top: 0.75rem;
  margin-bottom: 0.75rem;
`;

export const ProductDescription = styled.div`
  font-size: 1rem;
  line-height: 1rem;
`;

export const ProductPrice = styled.div`
  font-size: 2.5rem;
  font-weight: bold;
  margin-top: 0.5rem;
  margin-bottom: 0.5rem;
`;

export const AddToCart = styled.button``;
