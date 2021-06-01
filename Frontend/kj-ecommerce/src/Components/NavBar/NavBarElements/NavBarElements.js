import styled from "styled-components";

export const NavBarHeader = styled.header``;

export const NavBarContainer = styled.div`
  display: flex;
  align-items: center;
  background: #232a34;
  padding: 0.25rem;
  flex-grow: 1;
  padding-bottom: 0.5rem;
`;

export const NavBarLogoContainer = styled.div`
  display: flex;
  flex-grow: 1;
  align-items: center;
  margin-top: 0.5rem;

  @media (min-width: 640px) {
    flex-grow: 0;
  }
`;

export const NavBarLogoImg = styled.img`
  width: 140px;
  height: 140px;
  object-fit: contain;
  cursor: pointer;
`;

export const SearchBarContainer = styled.div`
  display: none;
  flex-grow: 1;
  background: #54647a;
  align-items: center;
  height: 2.5rem;
  border-radius: 0.25rem;
  cursor: pointer;

  @media (min-width: 640px) {
    display: flex;
  }
`;

export const SearchBarIconContainer = styled.div``;

export const SearchBarInput = styled.input`
  padding: 0.68rem;
  height: 100%;
  width: 1.5rem;
  flex-grow: 1;
  flex-shrink: 1;
  border-top-left-radius: 0.375rem;
  border-bottom-left-radius: 0.375rem;

  &:focus {
    outline: 2px solid transparent;
    outline-offset: 2px;
  }
`;


export const UserInfoContainer = styled.div`
  
`;

export const UserInfoWrapper = styled.div`
  
`;


export const UserAccountDiv = styled.div`
  
`;

export const OrdersDiv = styled.div`
  
`;

export const CartDiv = styled.div`
  
`;