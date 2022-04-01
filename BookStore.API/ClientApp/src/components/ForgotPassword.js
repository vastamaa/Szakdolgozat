import React, { Component } from 'react';
import { EmailChange } from './RegisterValid';

export class ForgotPassword extends Component {
    render() {

        async function handlePasswordResetSubmit() {

            let email = document.getElementById('email').value;

            try {
                const response = await fetch('api/accounts/reset-password',
                    {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json',
                            'Accept': 'application/json'
                        },
                        body: JSON.stringify({ "email": email })
                    });
                const data = await response.json();
                console.log(data);
            } catch (e) {
                console.log("A lekerdezes nem sikerult: ", e)
            }
            window.location.replace("https://localhost:5001/");
        }

        return (
            <div className='BaseSize'>
                <h1>Forgot Password</h1>
                <hr />
                <label className='login-label' htmlFor='forgotPassword'>Enter your email address:</label><br />
                <input className='login-input' type="email" name='email' placeholder='Enter your email address' id='email' onInvalid={EmailChange} onChange={EmailChange} required></input><br />
                <p style={{ float: 'left' }} className='none' id='emailerr'>Invalid Email (@ , .com)</p><br />
                <button onClick={handlePasswordResetSubmit} type='submit' className='login-btn'>Submit</button>
            </div>
        );
    }
}