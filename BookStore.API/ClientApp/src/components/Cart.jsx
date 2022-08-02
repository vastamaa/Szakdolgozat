import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap";
import { getData } from "./TokenDecode";
import React, { useEffect, useState } from "react";
import "./styleCart.css";

export const Cart = () => {
  const [sum, setSum] = useState(0);
  const [modal, setModal] = useState(false);
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");

  useEffect(() => {
    loadcart();
    const values = [];
    const keys = Object.keys(localStorage);
    let i = keys.length;
    while (i--) {
      values.push(localStorage.getItem(keys[i]));
    }
    let sumAll = values
      .map((item) => JSON.parse(item).price)
      .reduce((prev, curr) => prev + curr, 0);
    setSum(sumAll);
    let data = getData();
    if (data !== undefined) {
      setFirstName(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname"]
      );
      setLastName(
        data["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname"]
      );
    }
  }, []);

  const minusAmount = (isbn) => {
    localStorage.removeItem(isbn);
    window.location.reload(false);
  };

  const final = () => {
    alert("Order in progress we will notify you");
    history.pushState({}, {}, "/");
    localStorage.clear();
  };

  const loadCart = () => {
    const values = [];
    const keys = Object.keys(localStorage);
    let i = keys.length;
    while (i--) {
      values.push(localStorage.getItem(keys[i]));
    }

    let cartStatusMessage;
    if (sum === 0) {
      cartStatusMessage = <div>No items here</div>;
    } else {
      cartStatusMessage = (
        <div className="grid-item Summary">
          Summary: {sum} Ft
          <button onClick={() => setModal(!modal)} className="SummaryButton">
            Buy
          </button>
          <Modal
            isOpen={modal}
            toggle={() => setModal(!modal)}
            className="BookCardModal"
            size="lg"
          >
            <ModalHeader className="ModalTitle" toggle={() => setModal(!modal)}>
              Shipping
            </ModalHeader>
            <form onSubmit={final}>
              <ModalBody>
                <div>
                  <label>Full Name</label>
                  <br />
                  <input
                    type="text"
                    value={`${firstName} ${lastName}`}
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
                <Button
                  className="CancelButton"
                  onClick={() => setModal(!modal)}
                >
                  Cancel
                </Button>
              </ModalFooter>
            </form>
          </Modal>
        </div>
      );
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
                  onClick={() => minusAmount(JSON.parse(values).isbn)}
                >
                  -
                </button>
              </div>
            </>
          </div>
        ))}
        {cartStatusMessage}
      </div>
    );
  };

  return (
    <div className="BaseSize">
      <div className="CartContainer">
        <div className="Cart ">
          <div className="grid-item">{loadCart}</div>
        </div>
      </div>
    </div>
  );
};
