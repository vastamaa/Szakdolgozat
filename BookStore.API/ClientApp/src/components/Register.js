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
                    <div className='login-header'>Register:</div>
                    <div className='login-content'>

                        <div className='login-img-container'>
                            <img className='login-img' src="https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-600w-1365533969.jpg"></img>
                        </div>
                        <form className='login-form' action='api/accounts/register' onSubmit={handleFormRegisterSubmit}>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='firstName'>First Name</label>
                                <input className='login-input' type="text" name='firstName' placeholder='Enter your first name' id="firstName"></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='lastName'>Last Name</label>
                                <input className='login-input' type="text" name='lastName' placeholder='Enter your last name' id="lastName"></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='userName'>Username</label>
                                <input className='login-input' type="text" name='userName' placeholder='Enter your username' id="userName"></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='email'>Email</label>
                                <input className='login-input' type="text" name='email' placeholder='Enter your email' id="email"></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='password'>Password</label>
                                <input className='login-input' type="Password" name='password' placeholder='Enter your password' id="password"></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='confirmPassword'>Confirm Password</label>
                                <input className='login-input' type="Password" name='confirmPassword' id="confirmPassword" placeholder='Confirm your password'></input>
                            </div>
                            <div className='login-footer'>
                                <button type='submit' className='login-btn'>Submit</button>
                            </div>
                        </form>

                    </div>

                </div>
            </div>
        );
    }
}
