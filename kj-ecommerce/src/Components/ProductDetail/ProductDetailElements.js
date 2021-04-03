import styled from "styled-components";

export const ProductDetailContainer = styled.div`
  z-index: 2;
  background: rgba(255, 255, 255, 0.5);
  position: flex;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  display: flex;
  justify-content: center;
  align-items: center;
`;

export const ProductDetailCard = styled.div`
  position: relative;
  display: flex;
  width: 800px;
  height: 500px;
  margin: 20px;

  @media (max-width: 900px) {
    flex-direction: column;
    width: 550px;
    height: auto;
  }
`;

export const ProductDetailImgWrapper = styled.div`
  z-index: 2;
  background: #1d212b;
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 45%;
  height: 90%;
  transform: translateY(25px);
  border-top-left-radius: 10px;
  border-bottom-left-radius: 10px;

  @media (max-width: 900px) {
    z-index: 3;
    width: 100%;
    height: 200px;
    transform: translateY(0);
    border-bottom-left-radius: 0;
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
  }
`;

export const ProductDetailImg = styled.img`
  z-index: 2;
  position: relative;
  width: 450px;
  left: -50px;

  @media (max-width: 900px) {
    left: initial;
    max-width: 100%;
  }
`;

export const ProductDetailInfo = styled.div`
  z-index: 2;
  background: #555;
  display: flex;
  flex-direction: column;
  width: 55%;
  height: 100%;
  box-sizing: border-box;
  padding: 40px;
  border-radius: 10px;

  @media (max-width: 900px) {
    width: 100%;
    height: auto;
    padding: 20px;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
  }
`;

export const ProductDetailTitle = styled.h2`
  font-size: 40px;
  line-height: 20px;
  margin: 10px;

  @media (max-width: 900px) {
    margin: 20px 5px 5px 5px;
    font-size: 25px;
  }
`;

export const ProductDetailCategory = styled.span`
  font-size: 15px;
  text-transform: uppercase;
  letter-spacing: 2px;

  @media (max-width: 900px) {
    font-size: 10px;
  }
`;

export const ProductDetailDescription = styled.p`
  font-size: 15px;
  margin: 10px;

  @media (max-width: 900px) {
    margin: 5px;
    font-size: 13px;
  }
`;

export const ProductDetailCloseBtn = styled.button`
  color: #555;
  z-index: 3;
  position: absolute;
  right: 0;
  font-size: 20px;
  margin: 20px;
  cursor: pointer;

  @media (max-width: 900px) {
    z-index: 4;
  }
`;
