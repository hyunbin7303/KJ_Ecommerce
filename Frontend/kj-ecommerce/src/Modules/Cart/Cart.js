import React from 'react';
import { Switch, Route, Link } from "react-router-dom";
import {PrivateRoute} from '../../Auth/AuthFunctions';
import {useAuth} from '../../Auth/AuthFunctions';


const Cart = (props) => {

    let auth = useAuth();


    return (
        <>
            <PrivateRoute path="/cart">
                
                Your token is {auth.token}
            </PrivateRoute>
            

        </>

    );
}

export default Cart;
