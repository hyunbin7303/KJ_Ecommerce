import React from "react";
import {
  ProductDetailContainer,
  ProductDetailCard,
  ProductDetailImgWrapper,
  ProductDetailImg,
  ProductDetailInfo,
  ProductDetailCloseBtn,
  ProductDetailTitle,
  ProductDetailCategory,
  ProductDetailDescription,
} from "./ProductDetailElements";
import styled from 'styled-components';
import { MdClose } from "react-icons/md";

const CloseModalButton = styled(MdClose)`
  cursor: pointer;
  position: absolute;
  top: 20px;
  right: 20px;
  width: 32px;
  height: 32px;
  padding: 0;
  z-index: 10;
`;

const ProductDetail = ({
  showModal,
  setShowModal,
}, props) => {
  return (
    <>
      {showModal ? (
        <ProductDetailContainer>
          <ProductDetailCard>
            <ProductDetailImgWrapper>
              <ProductDetailImg src={props.src} />
            </ProductDetailImgWrapper>
            <ProductDetailInfo>
              <ProductDetailTitle>
                {props.title}
                <ProductDetailCategory>Technology</ProductDetailCategory>
                <ProductDetailDescription>
                  {props.description}
                </ProductDetailDescription>
              </ProductDetailTitle>
            </ProductDetailInfo>
          </ProductDetailCard>
          <CloseModalButton aria-label="Close Modal" onClick={() => setShowModal(prev => !prev)}/>
        </ProductDetailContainer>
      ) : null}
    </>
  );
};

export default ProductDetail;
