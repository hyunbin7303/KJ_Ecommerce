import React, { useState } from "react";
import {
  ListItemContainer,
  ListItemWrapper,
  ListItemTitle,
  ListItemImgWrapper,
  ListItemImg,
  ListItemInfo,
  ListItemButton,
} from "./ListItemElements/ListItemElements";
import axios from "axios";

import ProductDetail from "../ProductDetail/ProductDetail";

import TmpPic from "../../Assets/Images/TmpPic.png";

const ListItem = (props) => {
  const [showModal, setShowModal] = useState(false);

  const productDetailModel = {
    id: 0,
    Name: "",
    Description: "",
    DisplayName: "",
    UnitPrice: 0.0,
    UnitsInStock: "",
  };

  const [productInfomartion, setProductInformation] = useState(
    productDetailModel
  );

  const showDetails = (prodId) => {
    console.log("PRODID : " + prodId);
    getProductDetails(prodId);
    setShowModal((prev) => !prev);
  };

  const getProductDetails = async (prodId) => {
    await axios
      .get("/api/Product/Details", {
        params: { productId: prodId },
      })
      .then((response) => {
        setProductInformation({
          id: response.data.id,
          Name: response.data.name,
          Description: response.data.description,
          DisplayName: response.data.displayName,
          UnitPrice: response.data.unitPrice,
          UnitsInStock: response.data.unitsInStock,
        });
        console.log("Response Data: " + response);
        console.log("Response Data Name: " + response.data.name);
        console.log("Prod: " + productInfomartion.name);
      })
      .catch((error) => {
        console.log("ERROR getting response: " + error);
      });
  };

  return (
    <div>
      <ListItemContainer>
        <ListItemWrapper>
          <ListItemTitle>{props.ItemName}</ListItemTitle>
          <ListItemImgWrapper>
            <ListItemImg src="https://hpecommerce.blob.core.windows.net/kp-container/lord_of_the_ring_TheFellowshipOfTheRing.jpg" />
          </ListItemImgWrapper>
          <ListItemInfo>{props.ItemDescription}</ListItemInfo>
          <ListItemButton onClick={() => showDetails(props.ItemId + 1)}>
            View Product
          </ListItemButton>

          <ProductDetail
            key={productDetailModel.id}
            src={TmpPic}
            title={productDetailModel.name}
            description={productDetailModel.description}
            showModal={showModal}
            setShowModal={setShowModal}
          />
        </ListItemWrapper>
      </ListItemContainer>
    </div>
  );
};

export default ListItem;
