import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';
import React, { Component } from 'react';
import './styleCart.css';

export class Cart extends Component {
    
    constructor(props) {
        super(props);
        this.state = {
            sum: 0,
            modal: false
        };
        this.toggle = this.toggle.bind(this);
    }
    toggle() {
        this.setState({
            modal: !this.state.modal
        });
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
         console.log(sumall)
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
                    localStorage.removeItem(isbn)
                    window.location.reload(false);
            }
            return(
                <div>
                     {values.map((values)=>(
                                         
                         <div key={JSON.parse(values).isbn} className='CartItemsContainer' onClick={this.toggle}>
                             <>
                         <div className='CartImgContainer'>
                            <img className='CartImg' src={JSON.parse(values).img}></img>
                         </div>
                         <div className='CartInfo CartGrid'>
                         <p className='grid-item'><span className='CartAuth'>{JSON.parse(values).author}</span></p>
                         <p className='grid-item'><span className='CartTitle'>{JSON.parse(values).title}</span></p>
                         <p className='grid-item'><span className='CartGenre'>{JSON.parse(values).genre}</span></p>
                         <p className='grid-item'><span className='CartPrice'>{JSON.parse(values).price} Ft</span></p>
                         <button className='CartAmountButton' onClick={()=>MinusAmount(JSON.parse(values).isbn)}>-</button>
                         </div>
                         <Modal isOpen={this.state.modal} toggle={this.toggle} className="BookCardModal" size="lg">
                    <ModalHeader className='ModalTitle' toggle={this.toggle}>{JSON.parse(values).title}</ModalHeader>
                    <ModalBody>
                        <div>
                            <img className='ModalCardImg' src={JSON.parse(values).img}></img>
                            <p className='ModalRight '> <span className='ModalTextSpacing'>Author: {JSON.parse(values).author}</span><br />
                                <span className='ModalTextSpacing'>Genre: {JSON.parse(values).genre}</span><br />
                                <span className='ModalTextSpacing'>Language: {JSON.parse(values).lang}</span><br />
                                <span className='ModalTextSpacing'>Pages: {JSON.parse(values).pages}</span><br />
                                <span className='ModalTextSpacing'>ISBN: {JSON.parse(values).isbn}</span><br />
                                <span className='ModalTextSpacing'>Publisher: {JSON.parse(values).publisher}</span><br />
                                <span className='ModalTextSpacing'>Publishing Year: {JSON.parse(values).year}</span></p>
                        </div>
                        <hr />
                        <div>
                            <p className='ModalDesc'>Description</p>
                            <p className='Desc'>{JSON.parse(values).desc}</p>
                        </div>
                    </ModalBody>
                    <ModalFooter>
                        <Button className='CancelButton' onClick={this.toggle}>Cancel</Button>
                    </ModalFooter>

                </Modal>
                         </>
                         </div>
                     ))}
                    <div className='grid-item Summary' >
                         {this.state.sum} Ft
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