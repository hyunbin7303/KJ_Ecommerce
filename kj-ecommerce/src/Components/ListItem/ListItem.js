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

<<<<<<< HEAD
  const productDetailModel = {
    name: "nani",
=======
  const [productInfomartion, setProductInformation] = useState({
    name: "",
>>>>>>> a6d79959fd4806f37936f61128b757e342be339c
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
<<<<<<< HEAD
  };

  const [productInfomartion, setProductInformation] = useState(
    productDetailModel
  );

  console.log("NAME : " + productDetailModel.name);
=======
  });

>>>>>>> a6d79959fd4806f37936f61128b757e342be339c
  const showDetails = () => {
    getProductDetails();
    setShowModal((prev) => !prev);
  };

  const getProductDetails = async () => {
    await axios
      .get("/api/Product/Details", {
        params: { productId: "d630cf81-94eb-4d42-932f-131ea7ad8074" },
      })
      .then((response) => {
<<<<<<< HEAD
        setProductInformation({
          name: response.data.name,
          description: response.data.description,
          supplierId: response.data.supplierId,
          customerId: response.data.customerId,
          productFormat: response.data.productFormat,
          quantityPerUnit: response.data.quantityPerUnit,
          unitPrice: response.data.unitPrice,
          unitsInStock: response.data.unitsInStock,
          categoryId: response.data.categoryId,
          imageAddress: response.data.imageAddress,
          note: response.data.note,
          id: response.data.id,
        });
        console.log("Response Data: " + response);
        console.log("Response Data: " + response.data.name);
        console.log("Prod: " + productInfomartion.name);
=======
        setProductInformation(Object.assign(productInfomartion, response.data));

        console.log("Response Data: " + response.data.name);
        console.log("Prod: " + productInfomartion.description);
>>>>>>> a6d79959fd4806f37936f61128b757e342be339c
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
<<<<<<< HEAD
            key={productDetailModel.id}
            src={TmpPic}
            title={productDetailModel.name}
            description={productDetailModel.description}
=======
            key={productInfomartion.id}
            src={TmpPic}
            title={productInfomartion.name}
            description={productInfomartion.description}
>>>>>>> a6d79959fd4806f37936f61128b757e342be339c
            showModal={showModal}
            setShowModal={setShowModal}
          />
        </ListItemWrapper>
      </ListItemContainer>
    </div>
  );
};

export default ListItem;
