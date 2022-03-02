import React, { Component } from 'react';
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { IoSearchSharp } from "@react-icons/all-files/io5/IoSearchSharp";
import { AiOutlineShoppingCart } from "@react-icons/all-files/ai/AiOutlineShoppingCart";
import { readCookie } from "./CookieHandler";
import { logOut } from "./Log";
import './NavMenu.css';
import { FaBars } from "@react-icons/all-files/fa/FaBars";


export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true,
            loggedIn: readCookie("token")
        };
    }

    componentDidMount() {
        this.getUserName();
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    render() {
        return (
            <header className='stick-the-navbar'>
                {/* Example -- 'null = falshy' {this.state.loggedIn ? console.log("be van jelentkezve") : console.log("nincs bejelentkezve") };*/}

                <div className='NavContainer NavWrapper'>
                    <FaBars className='bars'></FaBars>
                    <div className='NavLeft'>
                        <span className='Lang'>EN</span>
                        <div className='SearchContainer'>
                            <input className='NavInput'></input>
                            <IoSearchSharp className='SearchButton' />
                        </div>
                    </div>

                    <div className='NavCenter'>
                        <NavLink tag={Link} to="/"> <h1 className='NavLogo text-dark'>Litera</h1></NavLink>
                    </div>
                    {this.state.loggedIn ? <div className='NavRight'>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/books" >Books</NavLink>
                        <AiOutlineShoppingCart size="30px "></AiOutlineShoppingCart>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/account/login" >Udvozollek, xy</NavLink>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/account/register" >Register</NavLink>
                        <NavLink tag={Link} onClick={logOut} className='NavMenuItem text-dark' to="/">Logout</NavLink>
                    </div> : <div className='NavRight'>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/account/login" >Login</NavLink>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/account/register" >Register</NavLink>
                    </div>}
                </div>
            </header>
        );
    }

    getUserName() {
        if (this.state.loggedIn != null) {
            var token = this.state.loggedIn;
            var decodedJwt = atob(token[1]);
            var firstData = decodedJwt.split(',');
            var name = firstData[0].split(':');

            console.log(name[2].slice(1, -1));
        }
    }
}
