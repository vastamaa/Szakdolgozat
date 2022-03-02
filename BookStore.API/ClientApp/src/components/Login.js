import React, { Component } from 'react';
import { handleFormLoginSubmit } from './Log';
import './styleLogin.css';


export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className='login-container'>
            <div className='login-border'>
                <div className='login-header'>Login</div>
                <div className='login-content'> 
                    <div className='login-img-container'>
                        <img className='login-img' src="https://image.shutterstock.com/image-vector/user-login-authenticate-icon-human-600w-1365533969.jpg"></img>
                    </div>
                    <form className='login-form' action='api/account/login' onSubmit={handleFormLoginSubmit}>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='username'>Username</label>
                            <input className='login-input' type="text" name='userName' placeholder='Username'></input>
                        </div>
                        <div className='login-form-group'>
                            <label className='login-label' htmlFor='Password'>Password</label>
                            <input className='login-input' type="Password" name='password' placeholder='Password'></input>
                        </div>
                        <div className='login-footer'>
                    <button type='submit' className='login-btn'>Login</button>
                         </div>
                    </form>
                </div>
 
                </div>
            </div>
          ///Kevés mező miatt csúszkál a login component
        );
    }
}
