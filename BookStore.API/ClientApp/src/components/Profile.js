import React, { Component } from "react";
import { getData } from './TokenDecode';

export class Profile extends Component {
    static displayName = Profile.name;

    constructor(props) {
        super(props);
        this.state = {
            userName: "",
            emailAddress: ""
        };
    }

    componentdidmount() {
        let data = getdata();
        if (data != undefined) {
            let name = data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];
            let email = data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
            console.log(email);
            this.setstate({ userName: name, emailAddress: email });
        }
    }

    render() {
        return (
            <div>
                <link
                    rel="stylesheet"
                    href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
                />
                <div className="card">
                    <h1>{ this.state.userName }</h1>
                    <p className="title">CEO &amp; Founder, Example</p>
                    <p>Harvard University</p>
                    <a href="#">
                        <i className="fa fa-dribbble" />
                    </a>
                    <a href="#">
                        <i className="fa fa-twitter" />
                    </a>
                    <a href="#">
                        <i className="fa fa-linkedin" />
                    </a>
                    <a href="#">
                        <i className="fa fa-facebook" />
                    </a>
                    <p>
                        <button>Contact</button>
                    </p>
                </div>
            </div>
            );
    }
}