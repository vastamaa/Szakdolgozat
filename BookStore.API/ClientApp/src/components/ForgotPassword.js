import React, { Component } from 'react'
import { EmailChange } from './RegisterValid'

export class ForgotPassword extends Component {
  render () {
    async function handlePasswordResetSubmit () {
      const email = document.getElementById('email').value

      try {
        const response = await fetch('api/accounts/reset-password', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
            Accept: 'application/json'
          },
          body: JSON.stringify({ email })
        })
        const data = await response.json()
        console.log(data)
      } catch (e) {}
      window.location.replace('https://localhost:5001/')
    }

    return (
      <div className="BaseSize">
        <h1>Forgot Password</h1>
        <hr />
        <form onSubmit={handlePasswordResetSubmit}>
          <div className="ForgotBox">
            <label className="login-label" htmlFor="forgotPassword">
              Enter your email address:
            </label>
            <br />
            <input
              className="login-input forgot"
              type="email"
              name="email"
              placeholder="Enter your email address"
              id="email"
              onInvalid={EmailChange}
              onChange={EmailChange}
              required
            ></input>
            <br />
            <p style={{ float: 'left' }} className="none" id="emailerr">
              Invalid Email (@ , .com)
            </p>
            <br />
          </div>
          <button type="submit" className="login-btn" id="ForgotButton">
            Submit
          </button>
        </form>
      </div>
    )
  }
}
