import React, { useEffect, useState } from 'react';
import { useForm, Controller } from 'react-hook-form';
import { InputText } from 'primereact/inputtext';
import { Button } from 'primereact/button';
import { InputNumber } from 'primereact/inputnumber';
import { Dropdown } from 'primereact/dropdown';
import { Calendar } from 'primereact/calendar';
import { Password } from 'primereact/password';
import { Checkbox } from 'primereact/checkbox';
import { Dialog } from 'primereact/dialog';
import { Divider } from 'primereact/divider';
import { classNames } from 'primereact/utils';

import { useHistory, useLocation } from "react-router-dom";
import {useAuth} from '../../Auth/AuthFunctions';

const ViewProducts = (props)=>{

    const [productList,setProductList] = useState([])
    let history = useHistory();
    let location = useLocation();
    let auth = useAuth();
    
    const getProducts = async ()=>{



        setProductList()
    }


    return (
        <>  {productList.length === 0 &&
                <div>
                    No products are currently listed. Please check back later.
                </div>
            }

            {productList.length > 0 &&
                <div className="">
                        
                </div>

            }

        </>

    )

}

export default ViewProducts;