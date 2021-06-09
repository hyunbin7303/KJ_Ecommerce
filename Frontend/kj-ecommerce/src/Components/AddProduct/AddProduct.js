import React, { Component } from "react";
import axios from "axios";

class AddProduct extends Component {
  sendPostReq = () => {
    axios
      .post("/api/Product", {
        id: "string2021",
        name: "TestPost4",
        description: "Shwoing Frontend to Hyunbin",
        supplierId: 1,
        customerId: "string4",
        productFormat: "string4",
        quantityPerUnit: 0,
        unitPrice: 0,
        unitsInStock: "string4",
        categoryId: 1,
        imageAddress: "string4",
        note: "string4",
      })
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(error);
      });
  };
  render() {
    return (
      <div>
        {/* This component will be used to create product */}
        <button onClick={this.sendPostReq}>Send Product</button>
      </div>
    );
  }
}

export default AddProduct;
