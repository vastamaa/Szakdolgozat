import React from "react";
import { NavLink } from "reactstrap";
import { Link } from "react-router-dom";
import { logOut } from "../Log";
import "../styleLogin.css";

export const SignedInNavMenu = ({ username }) => {
  return (
    <>
      <div className="NavRight">
        <NavLink
          tag={Link}
          onClick={() =>
            window.location.replace("https://localhost:5001/books")
          }
          className="NavMenuItem HoverUnderLine"
          to="/books"
        >
          Books
        </NavLink>
        <NavLink
          tag={Link}
          className="NavMenuItem HoverUnderLine"
          id="cartbutton"
          to="/cart"
        ></NavLink>
        <div className="dropdown">
          <span
            className="dropdown-toggle NavMenuItem text-dark "
            data-bs-toggle="dropdown"
          >
            Welcome, {username}
          </span>
          <div className="dropdown-menu dropdownthingy">
            <NavLink
              tag={Link}
              id="dropmenuitem"
              className="dropdown-item NavMenuItem HoverUnderLine "
              to="/accounts/profile-page"
            >
              Profile page
            </NavLink>
            <NavLink
              tag={Link}
              id="dropmenuitem"
              onClick={() => {
                setIsLoggedIn(logOut());
              }}
              className="dropdown-item NavMenuItem HoverUnderLine"
              to="/"
            >
              Logout
            </NavLink>
          </div>
        </div>
      </div>
      <div className="burgirDiv">
        <NavLink
          tag={Link}
          className="NavMenuItem HoverUnderLine burgirHead"
          to="/"
        >
          Home
        </NavLink>
        <NavLink
          tag={Link}
          className="NavMenuItem HoverUnderLine "
          to="/accounts/profile-page"
        >
          Profile
        </NavLink>
        <br />
        <NavLink tag={Link} className="NavMenuItem HoverUnderLine " to="/books">
          Books
        </NavLink>
        <br />
        <NavLink tag={Link} className="NavMenuItem HoverUnderLine " to="/cart">
          Cart
        </NavLink>
        <br />
        <NavLink
          tag={Link}
          onClick={logOut}
          className="NavMenuItem HoverUnderLine"
          to="/"
        >
          Logout
        </NavLink>
      </div>
    </>
  );
};
