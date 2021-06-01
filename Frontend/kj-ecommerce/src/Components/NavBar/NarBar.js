import React from "react";
import {
  CartDiv,
  NavBarContainer,
  NavBarHeader,
  NavBarLogoContainer,
  NavBarLogoImg,
  OrdersDiv,
  SearchBarContainer,
  SearchBarIconContainer,
  SearchBarInput,
  UserAccountDiv,
  UserAccountP,
  UserInfoContainer,
  UserInfoWrapper,
  OrdersP,
  CartP,
} from "./NavBarElements/NavBarElements";
import { MenuIcon, SearchIcon, ShoppingCartIcon } from "@heroicons/react/outline";
import classes from "./NavBar.module.css";
import Logo from "../../Assets/Images/KJ Ecommerce.png";

const NarBar = () => {
  return (
    <NavBarHeader>
      <NavBarContainer>
        {/* Nav Bar Logo Section*/}
        <NavBarLogoContainer>
          <NavBarLogoImg src={Logo} />
        </NavBarLogoContainer>

        {/* Search Bar Section*/}
        <SearchBarContainer>
          <SearchBarInput type="text" />
          <SearchBarIconContainer>
            <SearchIcon className={classes.SearchBar} />
          </SearchBarIconContainer>
        </SearchBarContainer>

        {/* Nav Bar UserInfo Section */}
        <UserInfoContainer>
          {/* Surrounding Wrapper */}
          <UserInfoWrapper>
            {/* User Account Div */}
            <UserAccountDiv>
              <p>Hello Julio </p>
              <UserAccountP>Account & list</UserAccountP>
            </UserAccountDiv>

            {/* Orders Div */}
            <OrdersDiv>
              <OrdersP>Orders</OrdersP>

            </OrdersDiv>

            {/* Cart Div */}
            <CartDiv>
              <ShoppingCartIcon className={classes.Cart} />
              <CartP>Cart</CartP>
            </CartDiv>
          </UserInfoWrapper>
        </UserInfoContainer>
      </NavBarContainer>
    </NavBarHeader>
  );
};

export default NarBar;
