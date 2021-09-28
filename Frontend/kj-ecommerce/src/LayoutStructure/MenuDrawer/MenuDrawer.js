import React, { useState } from 'react';
import { Sidebar } from 'primereact/sidebar';
import { Button } from 'primereact/button';
import {useAuth} from '../../Auth/AuthFunctions';






const MenuDrawer = (props) =>{

    const [visible, setVisible] = useState(props.visible);
    const auth = useAuth();
    // ok 

    return (
        <>
            <Sidebar visible={props.visible} onHide={() => props.setVisible(false)}>
                {(auth.user!== null && auth.user.role === 'sysAdmin') &&
                <ul>
                    <li>
                        <Button label='Products' onClick={() => { }} />

                    </li>
                    <li>
                        <Button label='Create Product' onClick={() => { }} />

                    </li>
                    <li>
                        <Button label='Update Product' onClick={() => { }} />

                    </li>
                </ul>} 
            </Sidebar>
        </>
    )
}

export default MenuDrawer;