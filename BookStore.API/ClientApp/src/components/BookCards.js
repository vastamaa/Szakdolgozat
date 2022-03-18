import React, { Component } from 'react';
import { NavItem } from 'reactstrap';
import { books } from './Data';
export class BookCards extends Component {
    render() {
        return (
            <div className='BookCardsContainer'>
        
            <>
        {books.map((item) => ( 
            <div className='card' style={{width:"300px"}}>
            <img className='card-img-top' src={item.Img} alt="Card image"/>
            <div className="card-body">
              <h4 className="card-title">{item.Title}</h4>
              <p className="card-text">{item.Genre}</p>
              <p className="card-text">{item.Publisher}</p>
              <p className="card-text">{item.Price}</p>
              <p className="card-text">{item.Desc}</p>
              <a href="#" className="btn btn-primary">Buy</a>
            </div>
            
          </div>
        ))};
          </>
          </div>
        );
    }
}