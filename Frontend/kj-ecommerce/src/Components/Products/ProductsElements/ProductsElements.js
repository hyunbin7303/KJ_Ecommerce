import styled from 'styled-components'

export const ProductsContainer = styled.ul`
    max-width: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
`;

export const ProductsList = styled.li` 
    list-style-type: none;
    padding: 0;
    flex: 0 1 34rem;
    margin: 1rem;
    height: 50rem;
    border-bottom: .1rem #c0c0c0 solid;
`;

export const Product = styled.div`
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    height: 100%;
`;

export const ProductImg = styled.img`
    max-height: 34rem;
    max-width: 34rem;
`;

export const ProductName = styled.div`
    font-size: 2rem;
    font-weight: bold;
`;

export const ProductDescription = styled.div`
    
`;

export const ProductPrice = styled.div`
    font-size: 2.5rem;
    font-weight: bold;
`;