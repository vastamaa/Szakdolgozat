import React, { Component } from 'react';
import { readCookie } from './CookieHandler';
import "./styleBookCards.css";
import { Button,Modal } from 'react-bootstrap';
import {ModalExample} from'./Modal';

export class Books extends Component {
    static displayName = Books.name;

    constructor(props) {
        super(props);
        this.state = { books: [], loading: true , collapsed: false };
        this.toggleModal = this.toggleModal.bind(this);
    }
    toggleModal() {
      const currentState = this.state.collapsed;
      this.setState({ collapsed: !currentState });
    }
    componentDidMount() {
        this.populateBooksData();
    }
    static renderBooksTable(books) {
      function on() {
       let a=document.getElementById("modal").classList;
       a.remove(a)
       a.add("ShowModal")
      }
      return (
        
        <div className='BookCardsContainerGrid'>
          
        <>
    {books.map((books) => ( 
        <div className='BookCard' style={{width:"400px", height:"600px"}} >
        <img className='card-img-top BookCardImg' src={books.imgLink} alt={books.imgLink}/>
        <div className="BookCardBody">
          <h4 className="card-title BookCardTitle NormalText" id="title">{books.title}</h4>
          <div className='BookCardBtn'>
          <button className='BookCardShow'>SHOW MORE</button>
          <ModalExample imglink={books.imgLink}/>
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
            : Books.renderBooksTable(this.state.books);

        return (
            <div >
                <h1 id="tabelLabel"  >All the books</h1>
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