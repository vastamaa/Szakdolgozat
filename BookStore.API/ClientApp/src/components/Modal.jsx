import React, { useState } from "react";
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap";
import { readCookie } from "./CookieHandler";
import "./styleBookCards.css";

export const BookModal = ({
  isbn,
  title,
  price,
  imgLink,
  genre,
  authorName,
  lang,
  publisher,
  publishingYear,
  desc,
  pages,
}) => {
  const [modal, setModal] = useState(false);

  const checkIfUserIsLoggedInAsync = async () => {
    readCookie("token") == null
      ? window.location.replace("https://localhost:5001/accounts/login")
      : localStorage.setItem(
          isbn,
          JSON.stringify({
            title,
            price,
            img: imgLink,
            isbn,
            genre,
            author: authorName,
            lang,
            publisher,
            year: publishingYear,
            desc,
          })
        );
  };

  return (
    <div className="BookCardBtn">
      <Button
        className="BookCardShow"
        onClick={() => {
          setModal(!modal);
        }}
      >
        SHOW MORE
      </Button>
      <Modal
        isOpen={modal}
        toggle={() => {
          setModal(!modal);
        }}
        className="BookCardModal"
        size="lg"
      >
        <ModalHeader
          className="ModalTitle"
          toggle={() => {
            setModal(!modal);
          }}
        >
          {title}
        </ModalHeader>
        <ModalBody>
          <div>
            <img className="ModalCardImg" src={imgLink}></img>
            <p className="ModalRight ">
              {" "}
              <span className="ModalTextSpacing">Author: {authorName}</span>
              <br />
              <span className="ModalTextSpacing">Genre: {genre}</span>
              <br />
              <span className="ModalTextSpacing">Language: {lang}</span>
              <br />
              <span className="ModalTextSpacing">Pages: {pages}</span>
              <br />
              <span className="ModalTextSpacing">ISBN: {isbn}</span>
              <br />
              <span className="ModalTextSpacing">Publisher: {publisher}</span>
              <br />
              <span className="ModalTextSpacing">
                Publishing Year: {publishingYear}
              </span>
            </p>
          </div>
          <hr />
          <div>
            <p className="ModalDesc">Description</p>
            <p className="Desc">{desc}</p>
          </div>
        </ModalBody>
        <ModalFooter>
          <p className="Price">
            <span className="PriceText">Price:</span> {price} Ft
          </p>
          <button
            className="BuyButton"
            id="buybutton"
            onClick={checkIfUserIsLoggedInAsync}
          >
            Buy
          </button>{" "}
          <Button
            className="Cancel"
            onClick={() => {
              setModal(!modal);
            }}
          >
            Cancel
          </Button>
        </ModalFooter>
      </Modal>
    </div>
  );
};
