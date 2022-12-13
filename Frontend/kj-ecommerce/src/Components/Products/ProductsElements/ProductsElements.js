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
  padding: 2.5rem;
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
  height: 25rem;
  width: 25rem;
  object-fit: contain;

  @media (max-width: 640px) {
    max-width: 100%;
  }

  @media (min-width: 768px) {
    max-width: 100%;
  }

  @media (min-width: 1280px) {
    max-width: 100%;
  }
`;

export const ProductName = styled.h4`
  font-size: 1.5rem;
  margin-top: 0.75rem;
  margin-bottom: 0.75rem;

  @media (min-width: 1280px) {
    font-size: 1.2rem;
  }
`;

export const ProductDescription = styled.p`
  font-size: 1rem;
  line-height: 1rem;
  margin-top: 1.25rem;
  margin-bottom: 1.25rem;
`;

export const ProductPrice = styled.p`
  font-size: 2.5rem;
  font-weight: bold;
  margin-top: 0.5rem;
  margin-bottom: 0.5rem;
`;

export const AddToCart = styled.button`
  cursor: pointer;
  padding: 14px 168px;
  margin-top: auto;
  font-size: 1rem;
  line-height: 1rem;
  background: #232a34;
  color: #FFF;
  outline: none;
  border: none;
  border-radius: 30px;
  transition: all 0.2s ease-in-out;
  
  &:hover {
    transition: all 0.2s ease-in-out;
    background: #3772FF;
  }

  @media (max-width: 640px) {
    padding: 12px 128px;
  }

  @media (max-width: 768px) {
    padding: 12px 140px;
  }

  @media (min-width: 980px) {
    padding: 12px 140px;
  }

  @media (max-width: 990px) {
    padding: 12px 130px;
  }

  @media (min-width: 1020px) {
    padding: 12px 150px;
  }

  @media (min-width: 1280px) {
    padding: 12px 70px;
  }
`;
