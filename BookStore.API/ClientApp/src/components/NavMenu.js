import React, { Component } from 'react'
import { NavLink } from 'reactstrap'
import { Link } from 'react-router-dom'
import { logOut } from './Log'
import './styleNavMenu.css'
import { getData } from './TokenDecode'

export class NavMenu extends Component {
  static displayName = NavMenu.name

  constructor (props) {
    super(props)
    this.toggleBurgir = this.toggleBurgir.bind(this)
    this.state = {
      collapsed: false,
      loggedIn: false,
      userName: ''
    }
  }

  toggleBurgir () {
    const currentState = this.state.collapsed
    this.setState({ collapsed: !currentState })
  }

  NavMenuLogOut () {
    this.setState({ loggedIn: logOut() })
  }

  componentDidMount () {
    const data = getData()
    if (data !== undefined) {
      this.setState({
        loggedIn: true,
        userName:
          data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name']
      })
    }
  }

  render () {
    return (
      <header className="stick-the-navbar">
        {/* Example -- 'null = falshy' {this.state.loggedIn ? console.log("be van jelentkezve") : console.log("nincs bejelentkezve") }; */}

        <div className="NavContainer NavWrapper">
          <div className="NavLeft">
            <span className="Lang">EN</span>
          </div>

          <div className="NavCenter">
            <NavLink tag={Link} to="/">
              {' '}
              <h1 className="NavLogo HoverUnderLine">Litera</h1>
            </NavLink>
          </div>
                {this.state.loggedIn
                  ? (
            <div className="NavRight">
              <NavLink
                tag={Link}
                onClick={() =>
                  window.location.replace('https://localhost:5001/books')
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
              >
              </NavLink>
              <div className="dropdown">
                <span
                  className="dropdown-toggle NavMenuItem text-dark "
                  data-bs-toggle="dropdown"
                >
                  Welcome, {this.state.userName}
                </span>
                <div className="dropdown-menu dropdownthingy">
                  {/* <a href="#" className="dropdown-item">Action</a> */}
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
                    onClick={this.NavMenuLogOut}
                    className="dropdown-item NavMenuItem HoverUnderLine"
                    to="/"
                  >
                    Logout
                  </NavLink>
                </div>
              </div>
            </div>
                    )
                  : (
            <div className="NavRight">
              <NavLink
                tag={Link}
                onClick={() =>
                  window.location.replace('https://localhost:5001/books')
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
            transform: this.state.collapsed
              ? 'translateX(0)'
              : 'translateX(100%)'
          }}
        >
          <div className="burgerClose" onClick={this.toggleBurgir}>
          </div>
          {this.state.loggedIn
            ? (
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
              )
            : (
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
    )
  }
}
