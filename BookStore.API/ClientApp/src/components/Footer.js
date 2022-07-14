import React, { Component } from 'react'
import './styleFooter.css'

export class Footer extends Component {
  render () {
    return (
      <div className="Footer-Box">
        <div className="Footer-Container">
          <div className="Footer-Row">
            <div className="Footer-Column">
              <p className="Footer-Heading">Partners</p>
              <a className="Footer-Link" href="#">
                Stackoverflow
              </a>
              <a className="Footer-Link" href="#">
                Indian guys from Youtube
              </a>
              <a className="Footer-Link" href="#">
                Random Strangers On the internet
              </a>
            </div>
            <div className="Footer-Column">
              <p className="Footer-Heading">Rights</p>
              <p>All rights are reserved by local community members</p>
            </div>
            <div className="Footer-Column">
              <p className="Footer-Heading">Contact Us</p>
              <a className="Footer-Link" href="#">
                Vaskó-Szedlár Tamás
              </a>
              <a className="Footer-Link" href="#">
                Almási Milán
              </a>
              <a className="Footer-Link" href="#">
                Váradi Nikoletta Brigitta
              </a>
            </div>
          </div>
        </div>
      </div>
    )
  }
}
