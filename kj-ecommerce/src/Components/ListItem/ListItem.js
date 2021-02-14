import React from "react";
import { ListItemContainer, ListItemWrapper, ListItemTitle, ListItemImg, ListItemInfo } from "./ListItemElements/ListItemElements";

const ListItem = (props) => {
  return (
    <div>
      <ListItemContainer>
        <ListItemWrapper>
          <ListItemTitle>Item Name</ListItemTitle>
          {/* <ListItemImg>Item Image</ListItemImg> */}
          <ListItemInfo>Description of Item</ListItemInfo>
        </ListItemWrapper>
      </ListItemContainer>
    </div>
  );
};

export default ListItem;
