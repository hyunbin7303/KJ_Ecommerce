import React from 'react';
import { Switch, Route, Link } from "react-router-dom";
import {PrivateRoute} from '../../Auth/AuthFunctions';


const Cart = (props) => {


    return (
        <>
            sdf
            <PrivateRoute path="/cart">
                hello
            </PrivateRoute>
            

        </>

    );
}

export default Cart;
