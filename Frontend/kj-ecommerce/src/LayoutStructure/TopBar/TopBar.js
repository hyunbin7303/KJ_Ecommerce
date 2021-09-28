import React, { useRef, useState } from 'react';
import { Link,useHistory } from "react-router-dom";
import { InputText } from 'primereact/inputtext';
import {useAuth} from '../../Auth/AuthFunctions';
import { Button } from 'primereact/button';
import MenuDrawer from '../MenuDrawer/MenuDrawer'


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
        <Button label="Login" className='p-button-info p-button-text' icon="pi pi-user" onClick={(e)=>{
            e.preventDefault();
            history.push('/login')
        }} />
    );
}


const TopBar = (props) => {
    let history = useHistory();
    const [searchValue, setSearchValue] = useState();
    const [visible,setVisible] = useState(false)

    return (
        <>
            <MenuDrawer visible={visible} setVisible={setVisible}/>
            <div className='topbarContainer'>
                <Button type="button" icon="pi pi-bars" onClick={(e)=>setVisible(true)}></Button>

                <div className='app-label'>

                    <Button label={`Kevin's Bike Store`} className="p-button-text p-button-primary" onClick={(e) => {
                        e.preventDefault();
                        history.push('/')

                    }} />
                </div>
                <div className=''>
                    <span className="p-input-icon-left">
                        <i className="pi pi-search" />
                        <InputText value={searchValue} onChange={(e) => setSearchValue(e.target.value)} placeholder='Search for product' />

                    </span>
                </div>

                <div className=' user-nav-group'>
                    <ul className='user-nav '>
                        <li>                           
                            <AuthButton/>
                            
                        </li>
                        <li>
                            <Button label='Cart' className="p-button-warning p-button-text" icon="pi pi-shopping-cart" onClick={(e) => {
                                e.preventDefault();
                                history.push('/cart')

                            }} />
                        </li>
                       
                    </ul>
                </div>
            </div>
        </>
    )
}

export default TopBar;