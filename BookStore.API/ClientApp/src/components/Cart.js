import React, { Component } from 'react';
import './styleCart.css';
import { MinusAmount,PlusAmount } from './CartFunctions';
import { JsxEmit } from 'typescript';

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
                                         
                         <div key={JSON.parse(values).isbn} className='CartItemsContainer'>
                             <>
                         <div className='CartImgContainer'>
                            <img className='CartImg' src={JSON.parse(values).img}></img>
                         </div>
                         <div className='CartInfo CartGrid'>
                        <p className='CartPrice grid-item' id='isbn'>{JSON.parse(values).isbn}</p>
                         <p className=' CartTitle grid-item'>{JSON.parse(values).title}</p>
                         <p className=' CartPrice grid-item'>{JSON.parse(values).price}</p>

                         </div>
                         <div className='Amount'>
                             <button className='CartAmountButton' onClick={MinusAmount}>-</button>
                             <input className='Amountinput' value={1} id='amount' ></input>
                             <button className='CartAmountButton' onClick={PlusAmount} >+</button>
                         </div>
                         </>
                         </div>
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
                        <div className='grid-item Summary'>
                            Price
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}