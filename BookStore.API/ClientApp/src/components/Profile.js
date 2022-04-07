import React, { Component } from "react";
import { getData } from "./TokenDecode";
import { PasswordChange, PasswordMatchChange, usernNameChange } from './RegisterValid';

import "./styleProfile.css"

export class Profile extends Component {
    static displayName = Profile.name;

    constructor(props) {
        super(props);
        this.handlePasswordChangeSubmit = this.handlePasswordChangeSubmit.bind(this);
        this.state = {
            userName: "",
            emailAddress: "",
            FirstName: "",
            LastName: ""
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
            alert("Can't Request:" + e)
        }
    }


    componentDidMount() {
        var data = getData();
        console.log(data)
        if (data != undefined) {
            this.setState({
                userName: data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'],
                emailAddress: data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'],
                FirstName: data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname'],
                LastName: data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname']
            });
        }
    }

    render() {
        function FadePw() {
            let formshow = document.getElementById("UsernameText")
            let formshowpw = document.getElementById("PasswordText")
            formshowpw.classList.toggle('fade');
            formshow.classList.remove('fade');
        }
        function FadeUser() {
            let formshow = document.getElementById("UsernameText")
            let formshowpw = document.getElementById("PasswordText")
            formshowpw.classList.remove('fade');
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
                        <p className="ProfileHead" >Name:<span>{this.state.FirstName} {this.state.LastName}</span></p>
                        <p className="ProfileBody" >Username:<span>{this.state.userName}</span></p>
                        <p className="ProfileBody">Email address: {this.state.emailAddress}</p>
                    </div>
                    <div className='ProfileRight'>
                        <img className='ProfileImg' id="imagedel" src="https://pic.onlinewebfonts.com/svg/img_550783.png"></img>
                    </div>
                    <button className="PasswordChange" onClick={FadePw}>Password change</button>
                    <form id="PasswordText" onSubmit={() => this.handlePasswordChangeSubmit()}>
                        <div className="PassWordChangeForm">
                            <label className='change-label' htmlFor="password" >New password:</label>
                            <input className='change-input' type='password' id="password" onChange={PasswordChange} onInvalid={PasswordChange} required></input>
                            <label htmlFor="password" className='none' id='passworderr' >&#09;Bad Formating</label>
                        </div>
                        <div className="PassWordChangeForm">
                            <label className='change-label' htmlFor="confirmPassword"  >New password again:</label>
                            <input className='change-input' type='password' id="confirmPassword" onInvalid={PasswordMatchChange} onChange={PasswordMatchChange} required></input>
                            <label htmlFor="confirmPassword" className='none' id='passwordmerr' >&#09;Doesn't Match</label><br />
                        </div>
                        <div>
                            <button type="submit" className="login-btn" id="passwordSubmit">Change my password!</button>
                        </div>
                    </form>

                    <button className="UsernameChange" onClick={FadeUser}>Username change</button>
                    <form id="UsernameText">
                        <div className="UsernameChangeForm">
                            <label className='change-label' htmlFor='userName'>Username</label>
                            <input className='change-input' type="text" name='userName' placeholder='Enter your username' onInvalid={usernNameChange} id="userName" onChange={usernNameChange} required></input>
                            <label htmlFor="userName" className='none' id='usernameerr' >&#09;Must contain atleast 6 characters</label>
                        </div>
                        <div>
                            <button type="submit" className="login-btn" id="userSubmit">Change my Username!</button>
                        </div>
                    </form>
                </div>
            </div>
        );
    }
}

