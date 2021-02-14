import React from "react";
import {
  ListItemContainer,
  ListItemWrapper,
  ListItemTitle,
  ListItemImg,
  ListItemInfo,
} from "./ListItemElements/ListItemElements";

const ListItem = (props) => {
  return (
    <div>
      <ListItemContainer>
        <ListItemWrapper>
          <ListItemTitle>{props.ItemName}</ListItemTitle>
          {/* <ListItemImg>{props.ItemImg}</ListItemImg> */}
          <ListItemInfo>{props.ItemDescription}</ListItemInfo>
        </ListItemWrapper>
      </ListItemContainer>
    </div>
  );
};

export default ListItem;
