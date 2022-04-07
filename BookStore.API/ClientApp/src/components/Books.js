import React, { Component } from 'react';
import { readCookie } from './CookieHandler';
import "./styleBookCards.css";
import { ModalExample } from './Modal';

export class Books extends Component {
    static displayName = Books.name;

    constructor(props) {
        super(props);
        this.state = { books: [], loading: true, collapsed: false };
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
            let a = document.getElementById("modal").classList;
            a.remove(a)
            a.add("ShowModal")
        }
        return (

            <div className='BookCardsContainerGrid'>

                <>
                    {books.map((books) => (
                        <div className='BookCard' style={{ minWidth: "95%", height: "600px" }} >
                            <img className='card-img-top BookCardImg' src={books.imgLink} alt={books.imgLink} />
                            <hr className='hr' />
                            <div className="BookCardBody">
                                <h4 className="card-title BookCardTitle NormalText" id="title">{books.title}</h4>
                                <ModalExample imgLink={books.imgLink} authorName={books.authorName} desc={books.description} genre={books.genreName} isbn={books.isbn} lang={books.languageName} pages={books.pageNumber} price={books.price} publisher={books.publisherName} publishingYear={books.publisherYear} title={books.title} />
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
            <div className='BaseSize'>
                <h1 id="tabelLabel">All the books</h1>
                {contents}
            </div>
        );
    }
    async populateBooksData() {

        var splitUrl = window.location.href.split('/');
        var url;

        if (splitUrl.length == 5) {
            url = `api/books/${splitUrl[4]}`;
        }
        else {
            url = `api/books`;
        }

        console.log(splitUrl);

        try {
            const response = await fetch(url,
                {
                    headers: {
                        'Authorization': `Bearer ${readCookie("token")}`,
                    }
                });
            const data = await response.json();
            console.log(data);
            this.setState({ books: data, loading: false });
        } catch (e) {
            console.log(`A lekerdezes nem sikerult: ${e}`)
        }

    }
}