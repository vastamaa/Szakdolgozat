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
                    <div className='login-header'>Login:</div>
                    <div className='login-content'>
                        <div className='login-img-container'>
                            <img className='login-img' src="https://pic.onlinewebfonts.com/svg/img_550783.png"></img>
                        </div>
                        <form className='login-form' action='api/accounts/login' onSubmit={handleFormLoginSubmit}>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='userName'>Username</label>
                                <input className='login-input' type="text" name='userName' placeholder='Enter your userName' id='userName'></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='password'>Password</label>
                                <input className='login-input' type="Password" name='password' placeholder='Enter your password' id='password'></input>
                            </div>
                            <div className='login-footer'>
                                <button type='submit' className='login-btn'>Submit</button>
                            </div>
                        </form>
                    </div>

                </div>
            </div>
            ///Kevés mező miatt csúszkál a login component
        );
    }
}
