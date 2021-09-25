import React from 'react';
import {Switch,Route,Link} from "react-router-dom";





const Main = (props) =>{





    return (
        <>
         <Switch>
          <Route exact path="/home">
            <div>hello</div>
          </Route>
          <Route path="/login">
            <div>login</div>

          </Route>
          <Route path="/cart">
            <div>cart</div>
          </Route>
        </Switch>
        </>
    )
}

export default Main;