import React, { useEffect, useState } from "react";
import { getData } from "./TokenDecode";
import { PasswordChange, PasswordMatchChange } from "./RegisterValid";

import "./styleProfile.css";

export const Profile = () => {
  const [userName, setUsername] = useState("");
  const [emailAddress, setEmailAddress] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");

  const handlePasswordChangeSubmit = async (event) => {
    event.preventDefault();
    const password = document.getElementById("password").value;

    try {
      const response = await fetch("api/accounts/change-password", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Accept: "application/json",
        },
        body: JSON.stringify({ password, email: this.state.emailAddress }),
      });
      const data = await response.json();
      console.log(data);
    } catch (e) {
      alert("Can't Request:" + e);
    }
  };

  const fadePasswordAway = () => {
    const formShowPw = document.getElementById("PasswordText");
    formShowPw.classList.toggle("fade");
  };

  useEffect(() => {
    const data = getData();
    if (data !== undefined) {
      setUsername(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]
      );
      setEmailAddress(
        data[
          "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"
        ]
      );
      setFirstName(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname"]
      );
      setLastName(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname"]
      );
    }
  }, []);

  return (
    <div className="ProfileContainer">
      <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
      />
      <div className="Profile">
        <div className="ProfileLeft">
          <p className="ProfileHead">
            Name:
            <span>
              {firstName} {lastName}
            </span>
          </p>
          <p className="ProfileBody">
            Username:<span>{userName}</span>
          </p>
          <p className="ProfileBody">Email address: {emailAddress}</p>
        </div>
        <div className="ProfileRight">
          <img
            className="ProfileImg"
            id="imagedel"
            src="https://pic.onlinewebfonts.com/svg/img_550783.png"
          ></img>
        </div>
        <button className="PasswordChange" onClick={fadePasswordAway}>
          Password change
        </button>
        <form id="PasswordText" onSubmit={handlePasswordChangeSubmit}>
          <div className="PassWordChangeForm">
            <label className="change-label" htmlFor="password">
              New password:
            </label>
            <input
              className="change-input"
              type="password"
              id="password"
              onChange={PasswordChange}
              onInvalid={PasswordChange}
              required
            ></input>
            <label htmlFor="password" className="none" id="passworderr">
              &#09;Bad Formating
            </label>
          </div>
          <div className="PassWordChangeForm">
            <label className="change-label" htmlFor="confirmPassword">
              New password again:
            </label>
            <input
              className="change-input"
              type="password"
              id="confirmPassword"
              onInvalid={PasswordMatchChange}
              onChange={PasswordMatchChange}
              required
            ></input>
            <label htmlFor="confirmPassword" className="none" id="passwordmerr">
              Doesn&apos;t Match
            </label>
            <br />
          </div>
          <div>
            <button type="submit" className="login-btn" id="passwordSubmit">
              Change my password!
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};
