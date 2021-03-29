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

  const [productInfomartion, setProductInformation] = useState({
    name: "",
    description: "",
    supplierId: 0,
    customerId: "",
    productFormat: "",
    quantityPerUnit: 0,
    unitPrice: 0,
    unitsInStock: "",
    categoryId: 0,
    imageAddress: "",
    note: "",
    id: "",
  });

  const showDetails = () => {
    getProductDetails();
    setShowModal((prev) => !prev);
  };

  const updatedProductInfo = {};

  const getProductDetails = async () => {
    await axios
      .get("/api/Product/Details", {
        params: { productId: "d630cf81-94eb-4d42-932f-131ea7ad8074" },
      })
      .then((response) => {
        setProductInformation(Object.assign(productInfomartion, response.data));

        console.log("Response Data: " + response.data.name);
        console.log("Prod: " + productInfomartion.description);
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
          <ListItemButton onClick={() => showDetails()}>
            View Product
          </ListItemButton>

          <ProductDetail
            key={productInfomartion.id}
            src={TmpPic}
            title={productInfomartion.name}
            description={productInfomartion.description}
            showModal={showModal}
            setShowModal={setShowModal}
          />
        </ListItemWrapper>
      </ListItemContainer>
    </div>
  );
};

export default ListItem;
