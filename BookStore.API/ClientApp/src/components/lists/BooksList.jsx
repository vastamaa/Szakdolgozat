import React from "react";
import "../styleBookCards.css";
import { BookModal } from "../Modal";

export const BooksList = ({ books }) => {
  return (
    <div className="BookCardsContainerGrid">
      <>
        {books.map((book) => (
          <div
            key={book.isbn}
            className="BookCard"
            style={{ minWidth: "95%", height: "600px" }}
          >
            <img
              className="card-img-top BookCardImg"
              src={book.imgLink}
              alt={book.imgLink}
            />
            <hr className="hr" />
            <div className="BookCardBody">
              <h4 className="card-title BookCardTitle NormalText" id="title">
                {book.title}
              </h4>
              <BookModal
                imgLink={book.imgLink}
                authorName={book.authorName}
                desc={book.description}
                genre={book.genreName}
                isbn={book.isbn}
                lang={book.languageName}
                pages={book.pageNumber}
                price={book.price}
                publisher={book.publisherName}
                publishingYear={book.publisherYear}
                title={book.title}
              />
            </div>
          </div>
        ))}
      </>
    </div>
  );
};
