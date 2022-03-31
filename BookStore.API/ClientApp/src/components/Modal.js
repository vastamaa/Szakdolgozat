import React, { Component } from 'react';
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';
import { Books } from './Books';
import "./styleBookCards.css";

export class ModalExample extends Component {
    constructor(props) {
        super(props);
        this.state = {
            modal: false
        };

        this.toggle = this.toggle.bind(this);
    }

   toggle() {
        this.setState({
            modal: !this.state.modal
        });
    }

    render() {
        return (
            <div className='BookCardBtn'>

                <Button className='BookCardShow' onClick={this.toggle}>SHOW MORE</Button>
                <Modal isOpen={this.state.modal} toggle={this.toggle} className="BookCardModal" size="lg">
                    <ModalHeader className='ModalTitle' toggle={this.toggle}>{this.props.title}</ModalHeader>
                    <ModalBody>
                        <div>
                        <img  className='ModalCardImg' src={this.props.imgLink}></img>
                        <p className='ModalRight '> <span className='ModalTextSpacing'>Author: {this.props.authorName}</span><br/>  
                        <span className='ModalTextSpacing'>Genre: {this.props.genre}</span><br/>
                        <span className='ModalTextSpacing'>Language: {this.props.lang}</span><br/>
                        <span className='ModalTextSpacing'>Pages: {this.props.pages}</span><br/>
                        <span className='ModalTextSpacing'>ISBN: {this.props.isbn}</span><br/>
                        <span className='ModalTextSpacing'>Publisher: {this.props.publisher}</span><br/>
                        <span className='ModalTextSpacing'>Publishing Year: {this.props.publishingYear}</span></p>
                        </div>
                        <hr/>
                        <div>
                            <p className='ModalDesc'>Description</p>
                            <p className='Desc'>{this.props.desc}</p>
                        </div>
                    </ModalBody>
                    <ModalFooter>
                        
                        <p className='Price'><span className='PriceText'>Price:</span>  {this.props.price} Ft</p>
                        <Button color="primary" onClick={this.toggle}>Buy</Button>{' '}
                        <Button color="secondary" onClick={this.toggle}>Cancel</Button>
                    </ModalFooter>
                </Modal>
            </div>
        );
    }
}

// publisher
//publishingYear
