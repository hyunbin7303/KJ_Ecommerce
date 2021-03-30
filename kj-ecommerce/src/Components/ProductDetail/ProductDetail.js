import React from "react";
import {
  ProductDetailContainer,
  ProductDetailCard,
  ProductDetailImgWrapper,
  ProductDetailImg,
  ProductDetailInfo,
  ProductDetailTitle,
  ProductDetailCategory,
  ProductDetailDescription,
  CloseModalButton
} from "./ProductDetailElements";

const ProductDetail = ({ showModal, setShowModal }, props) => {
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
          <CloseModalButton
            aria-label="Close Modal"
            onClick={() => setShowModal((prev) => !prev)}
          />
        </ProductDetailContainer>
      ) : null}
    </>
  );
};

export default ProductDetail;
