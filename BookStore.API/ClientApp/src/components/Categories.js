import React, { Component } from 'react';
 import { categories } from './Data';
import './styleCate.css';

export class Categories extends Component {
    render() {
        return (
        <div className='BigContainer'>
                 {categories.map((item)=>(
                <div className='Container img-hover-zoom img-hover-zoom--quick-zoom'>
                
                     <> 
                     <img className='Image' src={item.img}></img>
                     <div className='Info'>
                         <h1 className='Title' >{item.title}</h1> 
                         <p className='Desc'>{item.desc}</p>
                      </div>
                      </>
                      </div>
                 ))
                 } 
            
        </div>
        );
    }
}