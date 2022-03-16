import React, { Component } from 'react';
import { readCookie } from './CookieHandler';

export class Books extends Component {
    static displayName = Books.name;

    constructor(props) {
        super(props);
        this.state = { books: [], loading: true };
    }

    componentDidMount() {
        this.populateBooksData();
    }

    static renderBooksTable(books) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Title</th>
                        <th>Description</th>
                    </tr>
                </thead>
                <tbody>
                    {books.map(books =>
                        <tr key={books.id}>
                            <td>{books.id}</td>
                            <td>{books.title}</td>
                            <td>{books.description}</td>
                        </tr>
                    )}
                </tbody>
            </table>
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
            <div>
                <h1 id="tabelLabel" >All the books</h1>
                <p>This component demonstrates fetching data from the server.</p>
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
            this.setState({ books: data, loading: false });
        } catch (e) {
            console.log("A lekerdezes nem sikerult: ", e)
        }

    }
}
