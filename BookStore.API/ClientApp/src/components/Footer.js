import React, { Component } from 'react';
import "./styleFooter.css";

export class Footer extends Component {
    render() {
        return (
            <div className="Footer-Box">
                <div className="Footer-Container">
                    <div className="Footer-Row">
                        <div className="Footer-Column">
                            <p className="Footer-Heading">About Us</p>
                            <a className="Footer-Link" href="#">Aim</a>
                            <a className="Footer-Link" href="#">Vision</a>
                            <a className="Footer-Link" href="#">Testimonials</a>
                        </div>
                        <div className="Footer-Column">
                            <p className="Footer-Heading">Services</p>
                            <a className="Footer-Link" href="#">Writing</a>
                            <a className="Footer-Link" href="#">Shipping</a>
                            <a className="Footer-Link" href="#">Transactions</a>
                        </div>
                        <div className="Footer-Column">
                            <p className="Footer-Heading">Contact Us</p>
                            <a className="Footer-Link" href="#">Name</a>
                            <a className="Footer-Link" href="#">Name1</a>
                            <a className="Footer-Link" href="#">Name2</a>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}