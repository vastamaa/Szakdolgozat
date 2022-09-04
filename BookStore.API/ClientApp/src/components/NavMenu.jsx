import React, { useState, useEffect } from 'react';
import { NavLink, NavItem } from 'reactstrap';

import './navmenus/styleNavMenu.css';

import { getData } from './TokenDecode';
import { SignedInNavMenu } from './navmenus/SignedInNavMenu';
import { AnonymusNavMenu } from './navmenus/AnonymusNavMenu';

export const NavMenu = () => {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const [username, setUsername] = useState("");

  useEffect(() => {
    const data = getData();
    if (data !== undefined) {
      setIsLoggedIn(true);
      setUsername(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]
      );
    }
  }, []);

  return (
    <header className="stick-the-navbar">
      <div className="NavContainer d-flex flex-grow-1 align-items-center">
        <div className="NavLeft">
          <span className="language">EN</span>
        </div>

        <div>
          <NavItem className="d-flex flex-grow-1 align-self-center">
            <NavLink href="/">
              <h1 style={{ color: "black" }}>Litera</h1>
            </NavLink>
          </NavItem>
        </div>
        {isLoggedIn ? (
          <SignedInNavMenu username={username} />
        ) : (
          <AnonymusNavMenu />
        )}
      </div>
    </header>
  );
};
