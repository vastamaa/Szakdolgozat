import React, { Component } from 'react';
import '../custom.css';

export class SignUp extends Component {
    static displayName = SignUp.name;

  constructor(props) {
    super(props);
  }

  render() {
    return (
        <div>
            <h1 className="Register-Header">Register:</h1>

            <form action="api/account/signup" method="POST" className="form" id="form">
                <div className="form-group">
                    <label htmlFor="firstName">First Name</label>
                    <input type="text" className="form-control" name="firstName" id="firstName" placeholder="Enter first name"/>
                </div>
                <div className="form-group">
                    <label htmlFor="lastName">Last Name</label>
                    <input type="text" className="form-control" name="lastName" id="lastName" placeholder="Enter last name" />
                </div>
                <div className="form-group">
                    <label htmlFor="exampleInputEmail1">Email address</label>
                    <input type="email" className="form-control" name="email" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email" />
                    <small id="emailHelp" className="form-text text-muted">We'll never share your email with anyone else.</small>
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password</label>
                    <input type="password" className="form-control" name="password" id="password" placeholder="Password" />
                </div>
                <div className="form-group">
                    <label htmlFor="confirmPassword">Confirm Password</label>
                    <input type="password" className="form-control" name="confirmPassword" id="confirmPassword" placeholder="Password" />
                </div>
                <button type="submit" className="btn btn-primary">Submit</button>
            </form>
      </div>
      );
  }
}
