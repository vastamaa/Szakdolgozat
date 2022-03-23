import React, { Component } from 'react';
import { readCookie } from './CookieHandler';
import "./styleBookCards.css";


export class BookCards extends Component {
  static displayName = BookCards.name;

    constructor(props) {
        super(props);
        this.state = { books: [], loading: true };
    }

    componentDidMount() {
        this.populateBooksData();
    }
    static renderBooksTable(books) {
      return (
        <div className='BookCardsContainer'>
    
        <>
    {books.map((books) => ( 
        <div className='BookCard' style={{width:"300px"}}>
        <img className='card-img-top BookCardImg' src={books.imgLink} alt={books.imgLink}/>
        <div className="card-body">
          <h4 className="card-title BookCardTitle">{books.title}</h4>
          <p className="BookCardGenre"> {books.genreName}</p>
          <p className="BookCardPublish"> {books.publisherName}</p>
          <p className="BookCardPrice">{books.price} Euro</p>
          <div className='BookCardBtn'>
            <button className='BookCardShow'>SHOW MORE</button>
          </div>
        </div>
        
      </div>
    ))}
      </>
      </div>
    );
  }

    render() {
      let contents = this.state.loading
      ?
      <div className="d-inline-flex align-items-center">
          <div className="spinner-border ml-auto " role="status" aria-hidden="true"></div>
      </div>
      : BookCards.renderBooksTable(this.state.books);


  return (
      <div>
          <h1 id="tabelLabel" >All the books</h1>
          {contents}
      </div>
  );
    }
    async populateBooksData() {
      try {
          const response = await fetch('api/books',
              {
                  headers: {
                      'Authorization': `Bearer ${readCookie("token")}`,
                  }
              });
          const data = await response.json();
          console.log(data);
          this.setState({ books: data, loading: false });
      } catch (e) {
          console.log("A lekerdezes nem sikerult: ", e)
      }

  }
}