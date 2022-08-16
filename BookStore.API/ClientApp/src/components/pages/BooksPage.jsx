import React, { useEffect, useState } from "react";
import axios from "axios";

import { Spinner } from "reactstrap";

import { BooksList } from "../book/BooksList";

export const Books = () => {
  const [books, setBooks] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetchBooks();
  }, []);

  const getUrlFromAddressBar = () => {
    const splitUrl = window.location.href.split("/");

    return splitUrl.length === 5 ? `api/books/${splitUrl[4]}` : "api/books";
  };

  const fetchBooks = () => {
    axios
      .get(getUrlFromAddressBar())
      .then((response) => {
        setBooks(response.data);
        setLoading(false);
      })
      .catch((error) => console.log(error));
  };

  return (
    <div className="mt-3">
      <h1>All the books</h1>
      {loading && <Spinner animation="border" variant="warning" />}
      {!loading && <BooksList books={books} />}
    </div>
  );
};
