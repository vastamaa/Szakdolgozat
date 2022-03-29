import React, { Component } from 'react';
import { readCookie } from './CookieHandler';
import "./styleBookCards.css";
import Button from '@material-ui/core/Button';


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
        <div className='BookCardsContainerGrid'>
    
        <>
    {books.map((books) => ( 
        <div className='BookCard' style={{width:"400px", height:"600px"}} >
        <img className='card-img-top BookCardImg' src={books.imgLink} alt={books.imgLink}/>
        <div className="BookCardBody">
          <h4 className="card-title BookCardTitle NormalText" id="title">{books.title}</h4>
          <div className='BookCardBtn'>
            <button className='BookCardShow'>SHOW MORE</button>
            {/* <Button onClick={handleOpen}>Open modal</Button>
            <Modal
              open={open}
              onClose={handleClose}
              aria-labelledby="modal-modal-title"
              aria-describedby="modal-modal-description"
            >
              <Box sx={style}>
                <Typography id="modal-modal-title" variant="h6" component="h2">
                  Text in a modal
                </Typography>
                <Typography id="modal-modal-description" sx={{ mt: 2 }}>
                  Duis mollis, est non commodo luctus, nisi erat porttitor ligula.
                </Typography>
              </Box>
            </Modal> */}
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