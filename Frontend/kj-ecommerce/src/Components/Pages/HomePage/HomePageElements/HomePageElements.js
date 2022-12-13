import styled from "styled-components";

export const HomePageContainer = styled.div`
  background-color: rgba(243, 244, 246);
  justify-content: center;
  align-items: center;
  max-width: 1536px;
  margin-left: auto;
  margin-right: auto;
`;

export const HomePageProductGrid = styled.div`
  display: grid;
  grid-auto-flow: row dense;
  grid-template-columns: repeat(2, minmax(0, 1fr));
`;
