import React from "react";
import {NavBarContainer, NavBarHeader, NavBarLogoContainer, NavBarLogoImg} from './NavBarElements/NavBarElements';
import Logo from '../../Assets/Images/KJ Ecommerce.png';

const NarBar = () => {
    return (
        <NavBarHeader>
            <NavBarContainer>
                <NavBarLogoContainer>
                    <NavBarLogoImg src={Logo}/>
                </NavBarLogoContainer>
            </NavBarContainer>
        </NavBarHeader>
    )
}

export default NarBar
