import React, { Component } from 'react'
import './styleLogin.css'

export class ScrollToTop extends Component {
  constructor (props) {
    super(props)
    this.state = {
      isVisible: false
    }
  }

  componentDidMount () {
    const scrollComponent = this
    document.addEventListener('scroll', (e) => {
      scrollComponent.toggleVisibility()
    })
  }

  toggleVisibility () {
    if (window.pageYOffset > 300) {
      this.setState({
        isVisible: true
      })
    } else {
      this.setState({
        isVisible: false
      })
    }
  }

  scrollToTop () {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  render () {
    const { isVisible } = this.state
    return (
      <div className="scroll-to-top">
        {isVisible && (
          <div onClick={() => this.scrollToTop()}>
            <img
              src="https://i.postimg.cc/44Ytsk8Z/top-arrow-emoj.png"
              alt="Go to top"
            />
          </div>
        )}
      </div>
    )
  }
}
