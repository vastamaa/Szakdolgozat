import React, { Component } from 'react';
import { categories, showmore } from './Data';
import './styleCate.css';

export class Categories extends Component {
    render() {
        return (
            <div>
                <div className='BigContainer'>
                    {categories.map((item) => (
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
                {showmore.map((item) => (
                    <>
                        <div className='showmoreCategory'>
                            <div className='showmore-img-hover-zoom showmore-img-hover-zoom--quick-zoom showmoreBorder'>


                                <img className='showmoreImage' style={{ backgroundImage: `url(${item.image})` }} />
                                <div className='showmoreInfo'>
                                    <div className='showmoreText'>{item.text}</div>
                                </div>
                            </div>
                        </div>
                    </>
                ))}
            </div>
        );
    }
}