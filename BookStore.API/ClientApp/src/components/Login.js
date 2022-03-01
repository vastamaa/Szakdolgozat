import React, { Component } from 'react';
import { handleFormLoginSubmit } from './Log';
import '../custom.css';


export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <h1 className="mb-4 mt-4">Login:</h1>

                <form action='api/account/login' onSubmit={handleFormLoginSubmit}>
                    <div className="form-group mb-4">
                        <label htmlFor="userName">Username</label>
                        <input type="text" className="form-control" name="userName" id="userName" placeholder="Enter Username" />
                    </div>
                    <div className="form-group mb-4">
                        <label htmlFor="password">Password</label>
                        <input type="password" className="form-control" name="password" id="password" placeholder="Enter your password" />
                    </div>
                    <button type="submit" className="btn btn-outline-danger my-2 my-sm-0">Submit</button>
                </form>
            </div>
        );
    }
}
