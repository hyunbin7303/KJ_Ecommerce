import React from "react";
import {
  NavBarContainer,
  NavBarHeader,
  NavBarLogoContainer,
  NavBarLogoImg,
  SearchBarContainer,
  SearchBarInput,
} from "./NavBarElements/NavBarElements";
import Logo from "../../Assets/Images/KJ Ecommerce.png";

const NarBar = () => {
  return (
    <NavBarHeader>
      <NavBarContainer>
          {/* Nav Bar Logo */}
        <NavBarLogoContainer>
          <NavBarLogoImg src={Logo} />
        </NavBarLogoContainer>

        {/* Search Bar */}
        <SearchBarContainer>
          <SearchBarInput />
        </SearchBarContainer>
      </NavBarContainer>
    </NavBarHeader>
  );
};

export default NarBar;
