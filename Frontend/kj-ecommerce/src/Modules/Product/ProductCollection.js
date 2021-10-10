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
import { Card } from 'primereact/card';

import { useHistory, useLocation } from "react-router-dom";
import {useAuth} from '../../Auth/AuthFunctions';

const ProductCollection = (props)=>{

    const [productList,setProductList] = useState([])
    let history = useHistory();
    let location = useLocation();
    let auth = useAuth();

    const getProducts = async () => {
        // axios.get('http://b1f6-2607-9880-16e0-cd-193-e00c-3e3b-8643.ngrok.io/api/product')
        //     .then((response) => {
        //         cb()
        //     })
        //     .catch(error => {
        //         console.log(error)
        //     });


        setProductList(tempList)
    }

    useEffect(() => {
        setProductList(tempList)
    },[])

    const tempList = [
        {
            Name: 'Bike1',
            DisplayName: 'Bike 1',
            Description: 'Bike description',
            UnitPrice: 19.99,
            UnitsInStock: 10
        },
        {
            Name: 'Bike2',
            DisplayName: 'Bike 2',
            Description: 'Bike description',
            UnitPrice: 6.99,
            UnitsInStock: 5
        }
    ]

    const header = ()=> {

    }

    const footer = (props)=> {
        console.log('props',props)

        return (
            <span>
                <Button label="View Details" icon="pi pi-check" />
                <Button label="Add to Cart" icon="pi pi-shopping-cart" className="p-button-secondary p-ml-2" />
            </span>
        )
    }

    console.log('length',productList.length)

    return (
        <>  {productList.length === 0 &&
                <div>
                    No products are currently listed. Please check back later.
                </div>
            }

            {productList.length > 0 &&

                <div className="p-grid">
                    {productList.map((el, index) => {
                        return (
                            <div className='p-col p-m-2'>
                                <Card title={el.DisplayName} subTitle={`Available in Stock: ${el.UnitsInStock}`} style={{ width: '25em' }} footer={footer} header={header}>
                                    <p className="p-m-0" style={{ lineHeight: '1.5' }}>
                                        {el.Description}

                                    </p>
                                </Card>

                            </div>
                        )
                    })}
                </div>

            }

        </>

    )

}

export default ProductCollection;