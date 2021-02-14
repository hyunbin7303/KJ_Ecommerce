import React from "react";
import ListItem from "../ListItem/ListItem";

function List() {
  return (
    <div>
      <ListItem
        ItemName="Fiber Optic Cable"
        ItemDescription="Installing Fiber Optic Cable"
      />

      <ListItem
        ItemName="Wifi Installing"
        ItemDescription="Instaling wifi at location"
      />

      <ListItem
        ItemName="Lord of the Rings - Fellowship"
        ItemDescription="LOTR hard copy"
      />
    </div>
  );
}

export default List;
