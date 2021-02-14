import styled from "styled-components";

export const ListItemContainer = styled.div`
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: flex-end;
  margin: 10px;
  padding: 20px;
  width: 100%;
  max-height: 400px;
  min-width: 100px;
  background-color: #fff;
  z-index: 1;
`;

export const ListItemWrapper = styled.div`
  
`;

export const ListItemTitle = styled.h3`
  color: #000;
`;

export const ListItemImg = styled.img`
  max-height: 200px;
  width: 100%;
  object-fit: contain;
  margin-bottom: 15px;
`;

export const ListItemInfo = styled.p`
  color: #000;
  font-size: 20px;
`;
