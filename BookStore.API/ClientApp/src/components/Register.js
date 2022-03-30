import React, { Component } from 'react';
import { handleFormRegisterSubmit } from "./Log";
import { PasswordChange, PasswordMatchChange, EmailChange, usernNameChange, LastNameChange, FirstNameChange } from './RegisterValid';
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
                            <img className='login-img' src="https://pic.onlinewebfonts.com/svg/img_550783.png"></img>
                        </div>
                        <p className='none' id='SubmitValid'>Fill the boxes</p>
                        <form className='login-form' action='api/accounts/register' onSubmit={handleFormRegisterSubmit} id='form' >
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='firstName'>First Name</label>
                                <input className='login-input' type="text" name='firstName' placeholder='Enter your first name' onInvalid={FirstNameChange} id="firstName" onChange={FirstNameChange} required ></input>
                                <p className='none' id='firstnameerr'>Must contain atleast 3 charachters</p>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='lastName'>Last Name</label>
                                <input className='login-input' type="text" name='lastName' placeholder='Enter your last name' onInvalid={LastNameChange} id="lastName" onChange={LastNameChange} required></input>
                                <p className='none' id='lastnameerr'>Must contain atleast 3 charachters</p>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='userName'>Username</label>
                                <input className='login-input' type="text" name='userName' placeholder='Enter your username' onInvalid={usernNameChange} id="userName" onChange={usernNameChange} required></input>
                                <p className='none' id='usernameerr'>Must contain atleast 6 charachters</p>
                            </div>
                            <div className='login-form-group'>
                                <label className='login-label' htmlFor='email'>Email</label>
                                <input className='login-input' type="text" name='email' placeholder='Enter your email' id="email" onInvalid={EmailChange} onChange={EmailChange} required></input>
                                <p className='none' id='emailerr'>Invalid Email (@ , .com)</p>
                            </div>
                            <div className='login-form-group'>

                                <label className='login-label' htmlFor='password'>Password</label>
                                <input className='login-input' type="Password" name='password' id='password' onChange={PasswordChange} onInvalid={PasswordChange} placeholder='Enter your password' pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{5,}" required id="password"></input>
                                <p className='none' id='passworderr'>Must contain atleast 5 charachters  <br></br> 1 Capital, 1 Special Character</p>
                            </div>
                            <div className='login-form-group'>

                                <label className='login-label' htmlFor='confirmPassword'>Confirm Password</label>
                                <input className='login-input' type="Password" name='confirmPassword' id="confirmPassword" placeholder='Confirm your password' onInvalid={PasswordMatchChange} onChange={PasswordMatchChange} required></input>
                                <p className='none' id='passwordmerr'>Passwords must match</p>
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
