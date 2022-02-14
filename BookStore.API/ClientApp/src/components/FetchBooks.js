import React, { Component } from 'react';

export class FetchBooks extends Component {
  static displayName = FetchBooks.name;

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
      ? <p><em>Loading...</em></p>
      : FetchBooks.renderBooksTable(this.state.books);


    return (
      <div>
        <h1 id="tabelLabel" >All the books</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateBooksData() {
    const response = await fetch('api/books');
    const data = await response.json();
    this.setState({ books: data, loading: false });
  }
}
