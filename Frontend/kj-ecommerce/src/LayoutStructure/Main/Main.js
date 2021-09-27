import React from 'react';
import {Switch,Route,Link} from "react-router-dom";
import Login from '../../Modules/Admin/Login';
import Cart from '../../Modules/Cart/Cart';

const Main = (props) =>{





    return (
        <>
         <Switch>
          <Route exact path="/">
            <div>hello</div>
          </Route>
          <Route path="/login">
            <Login/>
          </Route>
          <Route path="/cart">
            
            <Cart/>
          </Route>
        </Switch>
        </>
    )
}

export default Main;