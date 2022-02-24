import React, { Component } from 'react';
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { IoSearchSharp } from "@react-icons/all-files/io5/IoSearchSharp";
import { AiOutlineShoppingCart } from "@react-icons/all-files/ai/AiOutlineShoppingCart";

import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true
        };
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    render() {
        return (
            <header>
                <div className='NavContainer NavWrapper'>

                    <div className='NavLeft'>
                        <span className='Lang'>EN</span>
                        <div className='SearchContainer'>
                            <input className='NavInput'></input>
                            <IoSearchSharp />
                        </div>
                    </div>

                    <div className='NavCenter'>
                        <h1 className='NavLogo'>Litera</h1>
                    </div>

                    <div className='NavRight'>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/books" >Books</NavLink>
                        <AiOutlineShoppingCart size="30px "></AiOutlineShoppingCart>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/account/login" >Login</NavLink>
                        <NavLink tag={Link} className='NavMenuItem text-dark' to="/account/register" >Register</NavLink>
                    </div>

                </div>

                {/* <Navbar className='navbar-expand-m navbar-toggleable-sm NavWrapper NavContainer'>
        <NavbarBrand className='NavCenter NavLogo' tag={Link} to="/">CoolWebshop</NavbarBrand>
        <NavbarToggler onClick={this.toggleNavbar} className='mr-2'/>
        <Collapse className='d-sm-inline-flex flex-sm-row-reverse' isOpen={!this.state.collapsed} navbar>
          <ul className="navbar-nav flex-grow">
              <NavItem>
                  <NavLink tag={Link} className='NavMenuItem' to="/counter">Counter</NavLink>
              </NavItem>
              <NavItem>
                  <NavLink tag={Link} className='NavMenuItem' to="/fetch-data">Fetch</NavLink>
              </NavItem>
              <NavItem>
                  <NavLink tag={Link} className='NavMenuItem' to="/fetch-books">Books</NavLink>
              </NavItem>
          </ul>
        </Collapse>
        </Navbar> */}
            </header>
        );
    }
}
