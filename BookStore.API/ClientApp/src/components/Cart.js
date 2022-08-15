import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap'
import { getData } from './TokenDecode'
import React, { Component } from 'react'
import './styleCart.css'

export class Cart extends Component {
  constructor (props) {
    super(props)
    this.state = {
      sum: 0,
      modal: false,
      FirstName: '',
      LastName: ''
    }
    this.toggle = this.toggle.bind(this)
  }

  toggle () {
    this.setState({
      modal: !this.state.modal
    })
  }

  componentDidMount () {
    this.loadcart()
    const values = []
    const keys = Object.keys(localStorage)
    let i = keys.length
    while (i--) {
      values.push(localStorage.getItem(keys[i]))
    }
    const sumall = values
      .map((item) => JSON.parse(item).price)
      .reduce((prev, curr) => prev + curr, 0)
    this.setState({ sum: sumall })
    const data = getData()
    if (data !== undefined) {
      this.setState({
        FirstName:
          data[
            'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname'
          ],
        LastName:
          data['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname']
      })
    }
  }

  loadcart () {
    const values = []
    const keys = Object.keys(localStorage)
    let i = keys.length
    while (i--) {
      values.push(localStorage.getItem(keys[i]))
    }
    function MinusAmount (isbn) {
      localStorage.removeItem(isbn)
      window.location.reload(false)
    }
    function Final () {
      alert('Order in progress we will notify you')
      history.pushState({}, {}, '/')
      localStorage.clear()
    }
    let final
    if (this.state.sum === 0) {
      final = <div>No item here</div>
    } else {
      final = (
        <div className="grid-item Summary">
          Summary: {this.state.sum} Ft
          <button onClick={this.toggle} className="SummaryButton">
            Buy
          </button>
          <Modal
            isOpen={this.state.modal}
            toggle={this.toggle}
            className="BookCardModal"
            size="lg"
          >
            <ModalHeader className="ModalTitle" toggle={this.toggle}>
              Shipping
            </ModalHeader>
            <form onSubmit={Final}>
              <ModalBody>
                <div>
                  <label>Full Name</label>
                  <br />
                  <input
                    type="text"
                    value={this.state.FirstName + ' ' + this.state.LastName}
                    required
                  ></input>
                  <br />
                  <label>Phone Number</label>
                  <br />
                  <input type="number" required></input>
                  <br />
                  <label>Country</label>
                  <br />
                  <input type="text" required></input>
                  <br />
                  <label>City</label>
                  <br />
                  <input type="text" required></input>
                  <br />
                  <label>ZIP Code</label>
                  <br />
                  <input type="number" required></input>
                  <br />
                  <label>Address</label>
                  <br />
                  <input type="text" required></input>
                  <br />
                </div>
              </ModalBody>
              <ModalFooter>
                <button type="submit" className="SummaryButton">
                  Pay
                </button>
                <Button className="CancelButton" onClick={this.toggle}>
                  Cancel
                </Button>
              </ModalFooter>
            </form>
          </Modal>
        </div>
      )
    }
    return (
      <div>
        {values.map((values) => (
          <div key={JSON.parse(values).isbn} className="CartItemsContainer">
            <>
              <div className="CartImgContainer">
                <img className="CartImg" src={JSON.parse(values).img}></img>
              </div>
              <div className="CartInfo CartGrid">
                <p className="grid-item">
                  <span className="CartAuth">{JSON.parse(values).author}</span>
                </p>
                <p className="grid-item">
                  <span className="CartTitle">{JSON.parse(values).title}</span>
                </p>
                <p className="grid-item">
                  <span className="CartGenre">{JSON.parse(values).genre}</span>
                </p>
                <p className="grid-item">
                  <span className="CartPrice">
                    {JSON.parse(values).price} Ft
                  </span>
                </p>
                <button
                  className="DeleteButtonCart"
                  onClick={() => MinusAmount(JSON.parse(values).isbn)}
                >
                  -
                </button>
              </div>
            </>
          </div>
        ))}
        {final}
      </div>
    )
  }

  render () {
    return (
      <div className="BaseSize">
        <div className="CartContainer">
          <div className="Cart ">
            <div className="grid-item">{this.loadcart()}</div>
          </div>
        </div>
      </div>
    )
  }
}
