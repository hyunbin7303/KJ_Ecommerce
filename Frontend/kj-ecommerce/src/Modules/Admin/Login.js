import React, { useEffect, useState } from 'react';
import { useHistory, useLocation } from "react-router-dom";
import {useAuth} from '../../Auth/AuthFunctions';
import { useForm, Controller } from 'react-hook-form';
import { InputText } from 'primereact/inputtext';
import { Button } from 'primereact/button';
import { Password } from 'primereact/password';
import { Checkbox } from 'primereact/checkbox';
import { classNames } from 'primereact/utils';

const Login = (props) =>{

    const [formData, setFormData] = useState({});
    let history = useHistory();
    let location = useLocation();
    let auth = useAuth();
    
    const defaultValues = {
        username: '',
        password: '',
        accept: false
    }
    const { control, formState: { errors }, handleSubmit, reset } = useForm({ defaultValues });

    const onSubmit = (data) => {
        setFormData(data);
        
        let { from } = location.state || { from: { pathname: "/" } };
        let login = () => {
    
            console.log(data)
    
            auth.signin(data.username,data.password,() => {
                history.replace(from);
    
            });

            auth.signin(data.username,data.password);
        };
        login()
        reset();
    };

    const getFormErrorMessage = (name) => {
        return errors[name] && <small className="p-error">{errors[name].message}</small>
    };
  
    return (
        <div className="">
            <div className="p-d-flex p-jc-center">
                <div className="card">
                    <h1 className="p-text-center">Login</h1>
                    <form onSubmit={handleSubmit(onSubmit)} className="p-fluid">
                        <div className="p-field">
                            <span className="p-float-label">
                                <Controller name="username" control={control} rules={{ required: 'Username is required.' }} render={({ field, fieldState }) => (
                                    <InputText id={field.username} {...field} autoFocus className={classNames({ 'p-invalid': fieldState.invalid })} />
                                )} />
                                <label htmlFor="username" className={classNames({ 'p-error': errors.username })}>Username*</label>
                            </span>
                            {getFormErrorMessage('username')}
                        </div>
                        {/* <div className="p-field">
                            <span className="p-float-label p-input-icon-right">
                                <i className="pi pi-envelope" />
                                <Controller name="email" control={control}
                                    rules={{ required: 'Email is required.', pattern: { value: /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$/i, message: 'Invalid email address. E.g. example@email.com' }}}
                                    render={({ field, fieldState }) => (
                                        <InputText id={field.name} {...field} className={classNames({ 'p-invalid': fieldState.invalid })} />
                                )} />
                                <label htmlFor="email" className={classNames({ 'p-error': !!errors.email })}>Email*</label>
                            </span>
                            {getFormErrorMessage('email')}
                        </div> */}
                        <div className="p-field">
                            <span className="p-float-label">
                                <Controller name="password" control={control} rules={{ required: 'Password is required.' }} render={({ field, fieldState }) => (
                                    <Password id={field.name} {...field} toggleMask className={classNames({ 'p-invalid': fieldState.invalid })} feedback={false}/>
                                )} />
                                <label htmlFor="password" className={classNames({ 'p-error': errors.password })}>Password*</label>
                            </span>
                            {getFormErrorMessage('password')}
                        </div>
                        <Button type="submit" label="Submit" className="p-mt-2" />
                    </form>
                </div>
            </div>
        </div>
    );
}

export default Login;