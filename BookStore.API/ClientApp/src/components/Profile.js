import React, { Component } from "react";
import { getData } from "./TokenDecode";
import "./styleProfile.css"

export class Profile extends Component {
    static displayName = Profile.name;

    constructor(props) {
        super(props);
        this.state = {
            userName: "",
            emailAddress: "",
            role: ""
        };
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

        async function handlePasswordChangeSubmit() {

            let password = document.getElementById('newPassword').value;
            let email = this.emailAddress;

            try {
                const response = await fetch('api/accounts/change-password',
                    {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json',
                            'Accept': 'application/json'
                        },
                        body: JSON.stringify({ "password": password, "email": email })
                    });
                const data = await response.json();
                console.log(data);
            } catch (e) {
                console.log("A lekerdezes nem sikerult: ", e)
            }
        }

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
                    <form id="PasswordText" className="" onSubmit={handlePasswordChangeSubmit}>
                        <div className="PassWordChangeForm">
                            <label htmlFor="changepw" >New password:</label>
                            <input type='password' id="newPassword"></input>
                        </div>
                        <div className="PassWordChangeForm">
                            <label htmlFor="changepw" >New password again:</label>
                            <input type='password' id="newPasswordAgain"></input><br />
                        </div>
                        <div>
                            <button type="submit" id="passwordSubmit">Change my password!</button>
                        </div>
                    </form>
                </div>
            </div>
        );
    }
}