import React, { Component } from 'react';
import { handleFormRegisterSubmit } from "./Log";
import './styleLogin.css';


export class Register extends Component {
    static displayName = Register.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className='login-container'>
            <div className='login-border'>
                <div className='login-header'>Register</div>
                <div className='login-content'>
                  
                    <div className='login-img-container'>
                        <img className='login-img' src="https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-600w-1365533969.jpg"></img>
                    </div>
                    <form className='login-form' action='api/account/register' onSubmit={handleFormRegisterSubmit}>
                    <div className='login-form-group'>
                            <label className='login-label' htmlFor='firstName'>First Name</label>
                            <input className='login-input' type="text" name='firstName' placeholder='First Name' id="firstName"></input>
                        </div>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='lastName'>Last Name</label>
                            <input className='login-input' type="text" name='lastName' placeholder='Last Name' id="lastName"></input>
                        </div>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='username'>Username </label>
                            <input className='login-input' type="text" name='userName' placeholder='Username' id="userName"></input>
                        </div>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='Email'>Email</label>
                            <input className='login-input' type="text" name='Email' placeholder='Email' id="email"></input>
                        </div>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='password'>Password</label>
                            <input className='login-input' type="Password" name='password' placeholder='Password' id="password"></input>
                        </div>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='confirmPassword'>Confirm Password</label>
                            <input className='login-input' type="Password" name='confirmPassword' id="confirmPassword"placeholder='Password'></input>
                        </div>
                    </form>
                    
                </div>
                <div className='login-footer'>
                    <button type='submit' className='login-btn'>Login</button>
                </div>
                </div>
            </div>
        );
    }
}
