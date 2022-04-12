import React, { Component } from 'react';
import './styleCart.css';

export class Cart extends Component {
    
    constructor(props) {
        super(props);
        this.state = {
            sum: 0
        };
    }
    componentDidMount() {
        this.loadcart();
                var values = [],
                keys = Object.keys(localStorage),
                i = keys.length;
            while ( i-- ) {
                values.push( localStorage.getItem(keys[i]) );
            }
         const sumall = values.map(item => JSON.parse(item).price).reduce((prev, curr) => prev + curr, 0);
         this.setState({sum:sumall})
    }
    loadcart(){
        var values = [],
                keys = Object.keys(localStorage),
                i = keys.length;
            while ( i-- ) {
                values.push( localStorage.getItem(keys[i]) );
            }
            function MinusAmount (isbn){
                var a=document.getElementById('amount').value
                if(a==1){
                    localStorage.removeItem(isbn)
                    window.location.reload(false);
                }
                else
                {
                    document.getElementById('amount').value=a-1;
                }
            }
            function PlusAmount(){
                var a=document.getElementById('amount').value
                a++;
                document.getElementById('amount').value=a
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
                         <p className=' CartPrice grid-item' onLoad={()=>Price(JSON.parse(values).price)}>{JSON.parse(values).price}</p>

                         </div>
                         <div className='Amount'>
                             <button className='CartAmountButton' onClick={()=>MinusAmount(JSON.parse(values).isbn)}>-</button>
                             <input className='Amountinput' value={1} id='amount' ></input>
                             <button className='CartAmountButton' onClick={PlusAmount}  >+</button>
                         </div>
                         </>
                         </div>
                     ))}
                    <div className='grid-item Summary' >
                         {this.state.sum}
                   </div>
                </div>
            )

    }
    render() {

        return (
            <div className='BaseSize'>
                <div className='CartContainer'>
                    <div className='Cart '>
                        <div className='grid-item'>
                            {this.loadcart()}
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}