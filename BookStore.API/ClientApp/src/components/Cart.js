import React, { Component } from 'react';
import './styleCart.css';

export class Cart extends Component {
    componentDidMount() {
        this.loadcart();
    }
    loadcart(){
        var values = [],
                keys = Object.keys(localStorage),
                i = keys.length;
            while ( i-- ) {
                values.push( localStorage.getItem(keys[i]) );
            }
            return(
                <div>
                     {values.map((values)=>(
                         <>                
                         <div className='CartItemsContainer'>
                         <div className='CartImgContainer'>
                            <img className='CartImg' src={JSON.parse(values).img}></img>
                         </div>
                         <div className='CartInfo CartGrid'>
                         <p className=' CartTitle grid-item'>{JSON.parse(values).title}</p>
                         <p className=' CartPrice grid-item'>{JSON.parse(values).price}</p>
                         
                         </div>
                         </div>
                         </>
                     ))}
                </div>
            )

    }
    render() {

        return (
            <div className='BaseSize'>
                <div className='CartContainer'>
                    <div className='Cart CartGrid'>
                        <div className='grid-item'>
                            {this.loadcart()}
                        </div>
                        <div className='grid-item'>
                            Price
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}