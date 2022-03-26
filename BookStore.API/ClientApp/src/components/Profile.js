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
        function PasswordChange() {
            
        }
        function Fadeform() {
            let formshow=document.getElementById("PasswordText")
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
                            <p className="ProfileHead" >Name:<span>{ this.state.userName }</span></p>
                            <p className="ProfileBody" >Username:<span>{ this.state.userName }</span></p>
                            <p className="ProfileBody">Role:<span>{ this.state.role }</span></p>
                            <p className="ProfileBody">Email address: { this.state.emailAddress }</p>
                        </div>
                        <div className='ProfileRight'>
                            <img className='ProfileImg' id="imagedel"src="https://pic.onlinewebfonts.com/svg/img_550783.png"></img>
                        </div>
                        <button className="PasswordChange"  onClick={Fadeform}>PasswordChange</button>
                        <form id="PasswordText" className="" onSubmit={PasswordChange}>
                            <div className="PassWordChangeForm">
                                <label for="changepw" >New Password:</label>
                                <input type='text' id="changepw"></input><br/> 
                            </div>
                            <div className="PassWordChangeForm">
                                <label for="changepw" >Old Password:</label>
                                <input type='text' id="oldpw"></input>
                            </div>
                            <div>
                                <button type="submit" id="pwchangesubmit">PasswordChange</button>
                            </div>
                        </form>
                    </div>
            </div>
        );
    }
}