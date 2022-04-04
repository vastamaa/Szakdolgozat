import React, { Component } from "react";
import { getData } from "./TokenDecode";
import { PasswordChange ,PasswordMatchChange} from './RegisterValid';

import "./styleProfile.css"

export class Profile extends Component {
    static displayName = Profile.name;

    constructor(props) {
        super(props);
        this.handlePasswordChangeSubmit = this.handlePasswordChangeSubmit.bind(this);
        this.state = {
            userName: "",
            emailAddress: "",
            role: ""
        };
    }

    async handlePasswordChangeSubmit(event) {
        event.preventDefault();
        let password = document.getElementById('password').value;

        try {
            const response = await fetch('api/accounts/change-password',
                {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'Accept': 'application/json'
                    },
                    body: JSON.stringify({ "password": password, "email": this.state.emailAddress })
                });
            const data = await response.json();
            console.log(data);
        } catch (e) {
            console.log("A lekerdezes nem sikerult: ", e)
        }
    }

    componentDidMount() {
        var data = getData();
        if (data != undefined) {
            let name = data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];
            let email = data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
            if (name != undefined) {
                this.setState({
                    userName: data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'],
                    emailAddress: data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'],
                    role: data['aud']
                });
            }
        }
    }

    render() {

        function Fadeform() {
            let formshow = document.getElementById("PasswordText")
            formshow.classList.toggle('fade');
        }

        return (
            <div className="ProfileContainer">
                <link
                    rel="stylesheet"
                    href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
                />
                <div className="Profile">
                    <div className="ProfileLeft">
                        <p className="ProfileHead" >Name:<span>{this.state.userName}</span></p>
                        <p className="ProfileBody" >Username:<span>{this.state.userName}</span></p>
                        <p className="ProfileBody">Role:<span>{this.state.role}</span></p>
                        <p className="ProfileBody">Email address: {this.state.emailAddress}</p>
                    </div>
                    <div className='ProfileRight'>
                        <img className='ProfileImg' id="imagedel" src="https://pic.onlinewebfonts.com/svg/img_550783.png"></img>
                    </div>
                    <button className="PasswordChange" onClick={Fadeform}>Password change</button>
                    <form id="PasswordText" className="" onSubmit={this.handlePasswordChangeSubmit}>
                        <div className="PassWordChangeForm">
                            <label className='changepw-label' htmlFor="changepw" >New password:</label>
                            <input className='changepw-input' type='password' id="password" onChange={PasswordChange} onInvalid={PasswordChange}  required></input>
                            <label htmlFor="changepw" className='none' id='passworderr' >&#09;Bad Formating</label>
                        </div>
                        <div className="PassWordChangeForm">
                            <label className='changepw-label' htmlFor="changepw"  >New password again:</label>
                            <input className='changepw-input' type='password' id="confirmPassword" onInvalid={PasswordMatchChange} onChange={PasswordMatchChange} required></input>
                            <label htmlFor="changepw" className='none' id='passwordmerr' >&#09;Doesn't Match</label><br />
                        </div>
                        <div>
                            <button type="submit" className="login-btn" id="passwordSubmit">Change my password!</button>
                        </div>
                    </form>
                </div>
            </div>
        );
    }
}