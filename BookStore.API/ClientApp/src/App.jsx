import React, { Component } from "react";
import { Route, Routes } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import { Books } from "./components/Books";
import { Register } from "./components/Register";
import { Login } from "./components/Login";
import { Profile } from "./components/Profile";
import { ForgotPassword } from "./components/ForgotPassword";
import { Cart } from "./components/Cart";
import "./custom.css";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div className="font-face-gm">
        <Layout className="stick-the-navbar">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/books" element={<Books />} />
            <Route path="/books/comics" element={<Books />} />
            <Route path="/books/children's fiction" element={<Books />} />
            <Route path="/books/literature" element={<Books />} />
            <Route path="/books/lifestyle" element={<Books />} />
            <Route path="/books/history" element={<Books />} />
            <Route path="/books/gastronomy" element={<Books />} />
            <Route path="/accounts/register" element={<Register />} />
            <Route path="/accounts/login" element={<Login />} />
            <Route path="/accounts/profile-page" element={<Profile />} />
            <Route
              path="/accounts/forgot-password"
              element={<ForgotPassword />}
            />
            <Route path="/cart" element={<Cart />} />
          </Routes>
        </Layout>
      </div>
    );
  }
}
