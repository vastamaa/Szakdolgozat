import React, { useState } from "react";
import { NavItem, NavLink, Nav } from "reactstrap";
import { useNavigate } from "react-router-dom";
import "../styleLogin.css";

export const AnonymusNavMenu = () => {
  const [isCollapsed, setIsCollapsed] = useState(false);
  const navigate = useNavigate();

  return (
    <>
      <div className="NavRight">
        <Nav>
          <NavItem>
            <NavLink
              className="NavMenuItem HoverUnderLine"
              onClick={() => {
                navigate("/books");
              }}
            >
              Books
            </NavLink>
          </NavItem>
          <NavItem>
            <NavLink
              className="NavMenuItem HoverUnderLine"
              onClick={() => {
                navigate("/accounts/login");
              }}
            >
              Login
            </NavLink>
          </NavItem>
          <NavItem>
            <NavLink
              className="NavMenuItem HoverUnderLine"
              onClick={() => {
                navigate("/accounts/register");
              }}
            >
              Register
            </NavLink>
          </NavItem>
        </Nav>
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
        <div className="burgirDiv">
          {/*<NavLink*/}
          {/*    tag={Link}*/}
          {/*    className="NavMenuItem HoverUnderLine burgirHead"*/}
          {/*    to="/"*/}
          {/*>*/}
          {/*    Home*/}
          {/*</NavLink>*/}
          {/*<NavLink*/}
          {/*    tag={Link}*/}
          {/*    className="NavMenuItem HoverUnderLine burgirList"*/}
          {/*    to="/accounts/login"*/}
          {/*>*/}
          {/*    Login*/}
          {/*</NavLink>*/}
          {/*<NavLink*/}
          {/*    tag={Link}*/}
          {/*    className="NavMenuItem HoverUnderLine burgirList"*/}
          {/*    to="/accounts/register"*/}
          {/*>*/}
          {/*    Register*/}
          {/*</NavLink>*/}
          /* Not working fully well. The burger menu icon has been removed, so
          its kinda off. */
          <Nav>
            <NavItem>
              <NavLink
                className="NavMenuItem HoverUnderLine burgirHead"
                onClick={() => {
                  navigate("/");
                }}
              >
                Home
              </NavLink>
            </NavItem>
            <NavItem>
              <NavLink
                className="NavMenuItem HoverUnderLine burgirList"
                onClick={() => {
                  navigate("/accounts/login");
                }}
              >
                Login
              </NavLink>
            </NavItem>
            <NavItem>
              <NavLink
                className="NavMenuItem HoverUnderLine burgirList"
                onClick={() => {
                  navigate("/accounts/register");
                }}
              >
                Register
              </NavLink>
            </NavItem>
          </Nav>
        </div>
      </div>
    </>
  );
};
