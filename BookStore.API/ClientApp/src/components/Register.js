import React, { Component } from 'react';
import { handleFormRegisterSubmit } from "./Log";
import '../custom.css';


export class Register extends Component {
    static displayName = Register.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <div>
                    <h1 className="mb-4 mt-4">Register:</h1>

                    <form action='api/account/register' onSubmit={handleFormRegisterSubmit}>
                        <div className="form-group mb-4">
                            <label htmlFor="firstName">First Name</label>
                            <input type="text" className="form-control" name="firstName" id="firstName" placeholder="Enter first name" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="lastName">Last Name</label>
                            <input type="text" className="form-control" name="lastName" id="lastName" placeholder="Enter last name" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="userName">Username</label>
                            <input type="text" className="form-control" name="userName" id="userName" placeholder="Enter Username" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="inputEmail1">Email address</label>
                            <input type="email" className="form-control" name="email" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email" />
                            <small id="emailHelp" className="form-text text-muted">We'll never share your email with anyone else.</small>
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="password">Password</label>
                            <input type="password" className="form-control" name="password" id="password" placeholder="Password" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="confirmPassword">Confirm Password</label>
                            <input type="password" className="form-control" name="confirmPassword" id="confirmPassword" placeholder="Password" />
                        </div>
                        <button type="submit" className="btn btn-outline-danger my-2 my-sm-0">Submit</button>
                    </form>
                </div>
            </div>
        );
    }
}
