import React, { useState, useEffect } from "react";
import { NavLink, NavItem } from "reactstrap";
import "./styleNavMenu.css";
import { getData } from "./TokenDecode";
import { SignedInNavMenu } from "./navmenus/SignedInNavMenu";
import { AnonymusNavMenu } from "./navmenus/AnonymusNavMenu";

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
            <div className="NavContainer NavWrapper">
                <div className="NavLeft">
                    <span className="Lang">EN</span>
                </div>

                <div className="NavCenter">
                    <NavItem>
                        <NavLink href="/"><h1 style={{ color: "black" }}>Litera</h1></NavLink>
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
