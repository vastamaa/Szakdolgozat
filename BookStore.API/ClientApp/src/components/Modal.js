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
                <Modal isOpen={this.state.modal} toggle={this.toggle} className="BookCardModal">
                    <ModalHeader className='ModalTitle' toggle={this.toggle}>{this.props.title}</ModalHeader>
                    <ModalBody className='ModalBody'>
                        <img className='ModalImage' src={this.props.imgLink}></img>
                    </ModalBody>
                    <ModalFooter className=''>
                        <Button color="primary" onClick={this.toggle}>Buy</Button>{' '}
                        <Button color="secondary" onClick={this.toggle}>Cancel</Button>
                    </ModalFooter>
                </Modal>
            </div>
        );
    }
}
// imgLink
// authorName
// desc
// genre
// isbn
// lang
// pages
// price
// publisher
//publishingYear
// title