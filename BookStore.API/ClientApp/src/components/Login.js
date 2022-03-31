import React, { Component } from 'react';
import { handleFormLoginSubmit } from './Log';
import './styleLogin.css';


export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
    }

    render() {
        function Loginerror() {
            const pw = document.getElementById("password").value;
            const pm = document.getElementById("userName").value;
            const pe = document.getElementById("loginsubmit");


            if (pw == "" || pm == "") {

                pe.classList.remove(pe.classList);
                pe.classList.add("error");

            } else {
                pe.classList.remove(pe.classList);
                pe.classList.add("valid")
            }
        }
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
                                <input className='login-input' type="text" name='userName' placeholder='Enter your userName' id='userName' onInvalid={Loginerror} required></input>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='password'>Password</label>
                                <input className='login-input' type="Password" name='password' placeholder='Enter your password' id='password' onInvalid={Loginerror} required></input>
                            </div>
                            <a className='login-label' href='/accounts/forgot-password'>Forgot password</a>
                            <div className='login-footer'>
                                <p className='none' id='loginsubmit'>Please fill the form</p>
                                <button type='submit' className='login-btn'>Submit</button>
                                <p className='none' id="loginfail">Login Failed</p>
                            </div>
                        </form>
                    </div>

                </div>
            </div>
            ///Kevés mező miatt csúszkál a login component
        );
    }
}
