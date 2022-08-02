import React from "react";
import { handleFormLoginSubmit } from "./Log";
import "./styleLogin.css";
import pfp from "../assets/profile.png";
import { LoginForm } from "./forms/LoginForm";

export const Login = () => {
  const LoginErrorAsync = async () => {
    const pw = document.getElementById("password").value;
    const pm = document.getElementById("userName").value;
    const pe = document.getElementById("loginsubmit");

    if (pw === "" || pm === "") {
      pe.classList.remove(pe.classList);
      pe.classList.add("error");
    } else {
      pe.classList.remove(pe.classList);
      pe.classList.add("valid");
    }
  };

  return (
    <div className="login-container">
      <div className="login-border">
        <div className="login-header">Login:</div>
        <div className="login-content">
          <div className="login-img-container">
            <img className="login-img" src={pfp}></img>
          </div>
          <LoginForm />
        </div>
      </div>
    </div>
    /// Kevés mező miatt csúszkál a login component
    /// 22.07.14 -- Fogalmam sincs tényleg emiatt csinálja-e. Akkor szerintem lövésünk se volt. Most meg nincs kedvem vele foglalkozni. -T
  );
};
