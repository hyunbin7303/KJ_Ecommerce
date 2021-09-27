import React, { useState } from 'react';
import { Link,useHistory } from "react-router-dom";
import { InputText } from 'primereact/inputtext';
import {useAuth} from '../../Auth/AuthFunctions';
import { Button } from 'primereact/button';


import './TopBarStyles.css'

function AuthButton() {
    let history = useHistory();
    let auth = useAuth();

    return auth.user ? (

        <div className='userDropdown'>
            <Button label={`Welcome! ${auth.user}`} className="p-button-text p-button-plain" />
            <div className='userMenu'>
                <button onClick={() => { 
                    auth.signout(() => history.push("/")) 
                }}>Sign out</button>
            </div>


        </div>

    ) : (
        <Button label="Login" icon="pi pi-user" onClick={(e)=>{
            e.preventDefault();
            //window.location.href = '/login';
            history.push('/login')
        }} />
    );
}


const TopBar = (props) => {

    const [searchValue, setSearchValue] = useState();

    return (
        <>
            <div className='topbarContainer'> 
                <div className='inline app-label'>
                    <Button label='KJ E-Commerce' className="p-button-text p-button-primary" onClick={(e)=>{
                        e.preventDefault();
                        window.location.href = '/';

                    }}  />

                    <Link to="/"></Link>
                </div>
                <div className='inline'>
                    <span className="p-input-icon-left">
                        <i className="pi pi-search" />
                        <InputText value={searchValue} onChange={(e) => setSearchValue(e.target.value)} placeholder='Search for product' />

                    </span>
                </div>

                <div className='inline user-nav-group'>
                    <ul className='user-nav '>
                        <li>
                           
                            <AuthButton/>



                            
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