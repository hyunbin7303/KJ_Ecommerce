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

  @media screen and (min-width: 640px) {
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

`;

export const SearchBarInput = styled.input`
  
`;
