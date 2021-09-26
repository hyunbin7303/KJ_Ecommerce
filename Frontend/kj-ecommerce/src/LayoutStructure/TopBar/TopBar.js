import React, { useState } from 'react';
import { Link } from "react-router-dom";
import { InputText } from 'primereact/inputtext';

import './TopBarStyles.css'




const TopBar = (props) => {

    const [searchValue, setSearchValue] = useState();

    return (
        <>
            <div className='topbarContainer'>
                <div className='inline app-label'><Link to="/">KJ E-Commerce</Link></div>
                <div className='inline'>
                    <span className="p-input-icon-left">
                        <i className="pi pi-search" />
                        <InputText value={searchValue} onChange={(e) => setSearchValue(e.target.value)} placeholder='Search for product' />

                    </span>
                </div>

                <div className='inline user-nav-group'>
                    <ul className='user-nav '>
                        <li>
                            <Link to="/Login">Login</Link>
                        </li>
                        <li>
                            <Link to="/Cart">Cart</Link>
                        </li>
                    </ul>
                </div>
            </div>
        </>
    )
}

export default TopBar;