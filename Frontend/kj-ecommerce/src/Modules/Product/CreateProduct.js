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
const CreateProduct = (props)=>{

    const [formData, setFormData] = useState({});
    const [unitPrice,setUnitPrice] = useState(0);
    let history = useHistory();
    let location = useLocation();
    let auth = useAuth();
    
    const defaultValues = {
        Name: '',
        DisplayName: '',
        Description: '',
        VendorId: -1,
        CategoryId: -1,
        UnitPrice: 0,
        Note:''
    }
    const { control, formState: { errors }, handleSubmit, reset } = useForm({ defaultValues });

    const onSubmit = (data) => {
        setFormData(data);
        
        // axios.post('http://b1f6-2607-9880-16e0-cd-193-e00c-3e3b-8643.ngrok.io/api/product',{
        //     "Username": username,
        //     "password": password
        // })
        // .then((response)=>{

        //     setUser(response.data.firstName);
        //     setToken(response.data.token)
        //     cb()
        // })
        // .catch(error => {
        //     console.log(error)
        // });

        console.log(JSON.stringify(data))



        reset();
    };

    const getFormErrorMessage = (name) => {
        return errors[name] && <small className="p-error">{errors[name].message}</small>
    };

    return (
        <div className="">
            <div className="p-d-flex p-jc-center">
                <div className="card">
                    <h1 className="p-text-center">Create Product</h1>
                    <form onSubmit={handleSubmit(onSubmit)} className="p-fluid">

                        <div className='p-fluid'>
                            <div className="p-grid">
                                <div className='p-field'>Product Name:</div>
                                <div className="p-field p-col-12">
                                    <span className="p-float-label">
                                        <Controller name="Name" control={control} rules={{ required: 'Product name is required.' }} render={({ field, fieldState }) => (
                                            <InputText id={field.name} {...field} autoFocus className={classNames({ 'p-invalid': fieldState.invalid })} />
                                        )} />
                                    </span>
                                    {getFormErrorMessage('Name')}
                                </div>
                            </div>
                            <div className="p-grid">
                                <div className='p-field'>Display Name:</div>
                                <div className="p-field p-col-12">
                                    <span className="p-float-label">
                                        <Controller name="DisplayName" control={control} rules={{ required: 'Display Name is required.' }} render={({ field, fieldState }) => (
                                            <InputText id={field.name} {...field} className={classNames({ 'p-invalid': fieldState.invalid })} />
                                        )} />
                                    </span>
                                    {getFormErrorMessage('DisplayName')}
                                </div>
                            </div>
                            <div className="p-grid">
                                <div className='p-field'>Description:</div>
                                <div className="p-field p-col-12">
                                    <span className="p-float-label">
                                        <Controller name="Description" control={control} rules={{ required: 'Description is required.' }} render={({ field, fieldState }) => (
                                            <InputText id={field.name} {...field} className={classNames({ 'p-invalid': fieldState.invalid })} />
                                        )} />
                                    </span>
                                    {getFormErrorMessage('Description')}
                                </div>
                            </div>
                            <div className="p-grid">
                                <div className='p-field'>Unit Price:</div>
                                <div className="p-field p-col-12">
                                    <span className="p-float-label">
                                        <Controller name="UnitPrice" control={control} rules={{ required: 'Unit Price is required.', min: { value: 0.01, message: 'Unit Price must be greater than $0.01.' } }} render={({ field, fieldState }) => (
                                            <InputNumber id={field.name} onValueChange={(e) => field.onChange(e.value)} value={field.value} className={classNames({ 'p-invalid': fieldState.invalid })} mode="currency" currency="USD" />
                                        )} />
                                    </span>
                                    {getFormErrorMessage('UnitPrice')}
                                </div>
                            </div>
                            <div className="p-grid">
                                <div className='p-field'>Note:</div>
                                <div className="p-field p-col-12">
                                    <span className="p-float-label">
                                        <Controller name="Note" control={control} render={({ field, fieldState }) => (
                                            <InputText id={field.name} {...field} className={classNames({ 'p-invalid': fieldState.invalid })} />
                                        )} />
                                    </span>
                                    {getFormErrorMessage('Note')}
                                </div>
                            </div>
                        </div>
                        <Button type="submit" label="Submit" className="p-mt-2" />
                    </form>
                </div>
            </div>
        </div>
    )

}

export default CreateProduct;