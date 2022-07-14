import React, { useEffect, useState } from "react";
import { NavLink } from "reactstrap";
import { Link } from "react-router-dom";
import { logOut } from "./Log";
import "./styleNavMenu.css";
import { getData } from "./TokenDecode";

export const NavMenu = () => {
  const [isCollapsed, setIsCollapsed] = useState(false);
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [userName, setUserName] = useState("");

  useEffect(() => {
    const data = getData();
    if (data !== undefined) {
      setIsLoggedIn(true);
      setUserName(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]
      );
    }
  }, []);

  return (
    <header className="stick-the-navbar">
      <div className="NavContainer NavWrapper">
        <div className="NavLeft">
          <span className="Lang">EN</span>
        </div>

        <div className="NavCenter">
          <NavLink tag={Link} to="/">
            {" "}
            <h1 className="NavLogo HoverUnderLine">Litera</h1>
          </NavLink>
        </div>
        {isLoggedIn ? (
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
                Welcome, {userName}
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
        ) : (
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
              to="/accounts/login"
            >
              Login
            </NavLink>
            <NavLink
              tag={Link}
              className="NavMenuItem HoverUnderLine"
              to="/accounts/register"
            >
              Register
            </NavLink>
          </div>
        )}
      </div>
      <div
        className="burgirMenu"
        style={{
          transform: isCollapsed ? "translateX(0)" : "translateX(100%)",
        }}
      >
        <div
          className="burgerClose"
          onClick={() => {
            setIsCollapsed(!isCollapsed);
          }}
        ></div>
        {isLoggedIn ? (
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
            <NavLink
              tag={Link}
              className="NavMenuItem HoverUnderLine "
              to="/books"
            >
              Books
            </NavLink>
            <br />
            <NavLink
              tag={Link}
              className="NavMenuItem HoverUnderLine "
              to="/cart"
            >
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
        ) : (
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
              className="NavMenuItem HoverUnderLine burgirList"
              to="/accounts/login"
            >
              Login
            </NavLink>
            <NavLink
              tag={Link}
              className="NavMenuItem HoverUnderLine burgirList"
              to="/accounts/register"
            >
              Register
            </NavLink>
          </div>
        )}
      </div>
    </header>
  );
};
