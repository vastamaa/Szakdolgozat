import React from "react";
import "./styleLogin.css";

export const AnonymusNavMenu = () => {
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
