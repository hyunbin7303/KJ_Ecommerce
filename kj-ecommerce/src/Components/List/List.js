import React, { Component } from "react";
import ListItem from "../ListItem/ListItem";
import axios from "axios";
import TmpPic from "../../Assets/Images/TmpPic.png";

class List extends Component {
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
      <div>
        {this.state.loading || !this.state.Items ? (
          <div>Loading ... </div>
        ) : (
          this.state.Items.map((listItem) => (
            <ListItem
              key={listItem.id}
              ItemName={listItem.name}
              ItemImg={TmpPic}
              ItemDescription={listItem.description}
            />
          ))
        )}
      </div>
    );
  }
}

export default List;
