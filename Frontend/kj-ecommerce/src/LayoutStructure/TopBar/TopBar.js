import React from 'react';
import {Link} from "react-router-dom";





const TopBar = (props) =>{


    return (
        <>
         <ul>
          <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <Link to="/Login">Login</Link>
          </li>
          <li>
            <Link to="/Cart">Cart</Link>
          </li>
        </ul>
        </>
    )
}

export default TopBar;