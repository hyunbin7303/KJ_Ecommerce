import React, { Component } from "react";
import axios from "axios";
import Products from "../../Components/Products/Products";

import {
  GridArea,
  GridContainer,
  Content,
} from "./ProductViewElements/ProductsViewElements";

// the purpose of this container is to get all the products from api call

class ProductsView extends Component {
  state = {
    loading: true,
    Items: [],
    error: false,
  };

  async componentDidMount() {
    await axios
      .get("/api/Product")
      .then((response) => {
        const fetchProducts = [];
        for (let key in response.data) {
          fetchProducts.push({
            ...response.data[key],
            id: key,
          });
        }
        this.setState({ Items: fetchProducts, loading: false });
        console.log(this.state.Items[0]);
      })
      .catch((error) => {
        this.setState({ error: true });
      });
  }

  render() {
    return (
      <GridArea>
        <GridContainer>
          <Content>
            {this.state.loading || !this.state.Items ? (
              <div>Loading ... </div>
            ) : (
              this.state.Items.map((Product) => (
                <Products
                  key={Product.id}
                  ProductName={Product.name}
                  ProductDescription={Product.description}
                  ProductPrice={'$'+ Product.unitPrice}
                />
              ))
            )}
          </Content>
        </GridContainer>
      </GridArea>
    );
  }
}

export default ProductsView;