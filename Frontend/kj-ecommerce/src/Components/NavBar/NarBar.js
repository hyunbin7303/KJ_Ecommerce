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
  UserInfoContainer,
  UserInfoWrapper,
} from "./NavBarElements/NavBarElements";
import { MenuIcon, SearchIcon, CartIcon } from "@heroicons/react/outline";
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

            </UserAccountDiv>

            {/* Orders Div */}
            <OrdersDiv>

            </OrdersDiv>

            {/* Cart Div */}
            <CartDiv>
              
            </CartDiv>
          </UserInfoWrapper>
        </UserInfoContainer>
      </NavBarContainer>
    </NavBarHeader>
  );
};

export default NarBar;
