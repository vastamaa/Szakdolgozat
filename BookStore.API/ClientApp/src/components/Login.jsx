import React from "react";
import "./styleLogin.css";
import pfp from "../assets/profile.png";
import { LoginForm } from "./forms/LoginForm";

export const Login = () => {
 
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
