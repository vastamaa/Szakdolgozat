import React, { Component } from 'react';
import { categories, categories2, showmore } from './Data';
import { Books } from './Books';
import './styleCate.css';

export class Categories extends Component {
    render() {
        function ShowMore() {
            let showmore=document.getElementById('showmorecategory');
            let tiles=document.getElementById('secondLine');
            showmore.classList.add("showmorebye");
            tiles.classList.add("secondLineHello")
        }
        return (
            <div>
                <div className='BigContainer'>
                    {categories.map((item) => (
                        <div onClick={() => window.location.replace("https://localhost:5001/books/" + item.title)} className='Container img-hover-zoom img-hover-zoom--quick-zoom'>

                            <>
                                <img className='Image' src={item.img}></img>
                                <div className='Info'>
                                    <h1 className='Title' >{item.title}</h1>
                                </div>
                            </>
                        </div>
                    ))
                    }

                </div>
                <div className='BigContainer secondlinehide' id='secondLine' >
                    {categories2.map((item) => (
                        <div onClick={() => window.location.replace("https://localhost:5001/books/" + item.title.toLowerCase())} className='Container img-hover-zoom img-hover-zoom--quick-zoom' id="secondLinePad" >

                            <>
                                <img className='Image' src={item.img}></img>
                                <div className='Info'>
                                    <h1 className='Title' >{item.title}</h1>
                                </div>
                            </>
                        </div>
                    ))
                    }

                </div>
                {showmore.map((item) => (
                    <>
                        <div className='showmoreCategory ' id="showmorecategory" onClick={ShowMore}>
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