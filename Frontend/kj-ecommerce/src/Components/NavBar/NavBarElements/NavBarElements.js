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
  display: flex;
  color: #fff;
  align-items: center;
`;

export const UserInfoWrapper = styled.div`
  display: flex;
  align-items: center;
  font-size: 0.75rem;
  line-height: 1rem;

  --space-x-reverse: 0;

  margin-right: calc(1.5rem * var(--space-x-reverse));
  margin-left: calc(1.5rem * calc(1 - var(--space-x-reverse)));

  margin-left: 1.5rem /* 24px */;
  margin-right: 1.5rem /* 24px */;
`;

export const UserAccountDiv = styled.div`
  cursor: pointer;

  &:hover {
    text-decoration: underline;
  }
`;

export const UserAccountP = styled.p`
  font-weight: 800;

  @media (min-width: 768px) {
    font-size: 0.875rem;
    line-height: 1.25rem;
  }
`;

export const OrdersDiv = styled.div`
  cursor: pointer;
  --space-x-reverse: 0;

  margin-right: calc(1.5rem * var(--space-x-reverse));
  margin-left: calc(1.5rem * calc(1 - var(--space-x-reverse)));

  &:hover {
    text-decoration: underline;
  }
`;

export const OrdersP = styled.p`
  font-weight: 800;

  @media (min-width: 768px) {
    font-size: 0.875rem;
    line-height: 1.25rem;
  }
`;

export const CartDiv = styled.div`
  cursor: pointer;
  --space-x-reverse: 0;

  margin-right: calc(1.5rem * var(--space-x-reverse));
  margin-left: calc(1.5rem * calc(1 - var(--space-x-reverse)));

  &:hover {
    text-decoration: underline;
  }
`;

export const CartP = styled.p`
  margin-left: 0.5rem;
  font-weight: 800;
  @media (min-width: 768px) {
    font-size: 0.875rem;
    line-height: 1.25rem;
  }
`;
