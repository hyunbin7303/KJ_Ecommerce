import React from "react";
import {
  CartDiv,
  NavBarContainer,
  NavBarHeader,
  NavBarLogoContainer,
  NavLink,
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
  CartItemsContainer,
} from "./NavBarElements/NavBarElements";
import { SearchIcon, ShoppingCartIcon } from "@heroicons/react/outline";
import classes from "./NavBar.module.css";
import Logo from "../../Assets/Images/KJ Ecommerce.png";

const NarBar = () => {
  return (
    <NavBarHeader>
      <NavBarContainer>
        {/* Nav Bar Logo Section*/}
        <NavBarLogoContainer>
          <NavLink to="/">
            <NavBarLogoImg src={Logo} />
          </NavLink>
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
              <NavLink to="/checkout">
                <CartItemsContainer>0</CartItemsContainer>
                <ShoppingCartIcon className={classes.Cart} />
                <CartP>Cart</CartP>
              </NavLink>
            </CartDiv>
          </UserInfoWrapper>
        </UserInfoContainer>

        {/* Maybe add categories underneath navbar like amazon */}
      </NavBarContainer>
    </NavBarHeader>
  );
};

export default NarBar;
