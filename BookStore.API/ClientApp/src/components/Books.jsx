import React, { useEffect, useState } from "react";
import { Spinner } from "reactstrap";
import { BooksList } from "./lists/BooksList";
import { populateBooksData } from './Log';
import "./styleBookCards.css";

export const Books = () => {
  const [books, setBooks] = useState([]);
  const [loading, setLoading] = useState(true);

    useEffect(() => {
        populateBooksData().then((response) => console.log(response.data));
  }, []);
  //const populateBooksData = async () => {
  //  const splitUrl = window.location.href.split("/");
  //  console.log(splitUrl);
  //  let url;

  //  splitUrl.length === 5
  //    ? (url = `api/books/${splitUrl[4]}`)
  //    : (url = "api/books");

  //  try {
  //    const response = await fetch(url);
  //    const data = await response.json();
  //    setBooks(data);
  //    setLoading(false);
  //  } catch (err) {
  //    console.log(err);
  //  }
  //};

  return (
    <div className="BaseSize">
      <h1 id="tabelLabel">All the books</h1>
      {loading ? (
        <Spinner animation="border" variant="warning" />
      ) : (
        <BooksList books={books} />
      )}
    </div>
  );
};
