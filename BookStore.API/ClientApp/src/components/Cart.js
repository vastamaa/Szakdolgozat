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
                         <p className=''>{JSON.parse(values).title}</p>
                         <p className=''>{JSON.parse(values).price}</p>
                         <img className='' src={JSON.parse(values).img}></img>
                         </>
                     ))}

                </div>
            )

    }
    render() {

        return (
            <div className='BaseSize'>
                <div className='CartContainer'>
                    <div className='Cart'>
                    {this.loadcart()}
                    </div>
                </div>
            </div>
        );
    }
}