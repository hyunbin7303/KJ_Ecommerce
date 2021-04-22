import styled from "styled-components";

export const ListItemContainer = styled.div`
  position: relative;
  display: flex;
  jusitfy-content: center;
  align-items: center;
  width: 100%;
  height: 100vh;
  margin-top: -200px;
  margin-bottom: -500px;
`;

export const ListItemWrapper = styled.div`
  z-index: 1;
  background: #1d212b;
  position: relative;
  width: 300px;
  height: 400px;
  margin: 40px;
  border-radius: 10px;

  &:before {
    content: "";
    background: rgba(255, 255, 255, 0.1);
    position: absolute;
    display: block;
    top: 0;
    left: 0;
    width: 50%;
    height: 100%;
    border-top-left-radius: 10px;
    border-bottom-left-radius: 10px;
  }
`;

export const ListItemTitle = styled.h3`
  z-index: 2;
  color: #fff;
  position: absolute;
  width: 100%;
  text-align: center;
  bottom: 130px;
  font-size: 20px;
  letter-spacing: 1px;
`;

export const ListItemImgWrapper = styled.div`
  z-index: 1;
  position: absolute;
  max-width: 450px;
  top: 30%;
  left: 50%;
  transform: translate(-50%, -50%);
`;

export const ListItemImg = styled.img`
  width: 100%;
`;

export const ListItemInfo = styled.p`
  z-index: 2;
  color: #fff;
  position: absolute;
  width: 100%;
  text-align: center;
  bottom: 80px;
  font-size: 15px;
  font-weight: 300;
`;

export const ListItemButton = styled.button`
  z-index: 2;
  color: #fff;
  background: #555;
  position: absolute;
  bottom: 20px;
  left: 50%;
  transform: translateX(-50%);
  font-size: 14px;
  text-transform: uppercase;
  text-decoration: none;
  letter-spacing: 1px;
  padding: 10px 15px;
  border-radius: 20px;
  cursor: pointer;
`;
