import React, { useEffect, useState } from "react";
import { readCookie } from "./CookieHandler";
import "./styleBookCards.css";
import { BookModal } from "./Modal";

export const Books = () => {
  const [books, setBooks] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    populateBooksData();
  }, []);

  const populateBooksData = async () => {
    const splitUrl = window.location.href.split("/");
    let url;

    splitUrl.length === 5
      ? (url = `api/books/${splitUrl[4]}`)
      : (url = "api/books");

    try {
      const response = await fetch(url, {
        headers: {
          Authorization: `Bearer ${readCookie("token")}`,
        },
      });
      const data = await response.json();
      setBooks(data);
      setLoading(false);
    } catch (err) {
      console.log(err);
    }
  };

  const renderBooksTable = (books) => {
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
  return (
    <div className="BaseSize">
      <h1 id="tabelLabel">All the books</h1>
      {loading ? (
        <div
          className="spinner-border"
          style={{ width: "3rem", height: "3rem" }}
          role="status"
        ></div>
      ) : (
        renderBooksTable(books)
      )}
    </div>
  );
};
