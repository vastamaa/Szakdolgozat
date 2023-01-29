import React, { Component } from "react";
import { sliders as sliderItems } from "./datas/DataRelatedToCategoriesAndTheSlider";
import "./styleSlider.css";

export class Slider extends Component {
  static displayName = Slider.name;

  constructor(props) {
    super(props);
    this.state = { slideIndex: 0, loading: true };
  }

  handleClick = (direction) => {
    if (direction === "left") {
      const counter = this.state.slideIndex - 1;
      if (counter >= 0) {
        this.setState({ slideIndex: counter, loading: false });
      } else {
        this.setState({ slideIndex: 2, loading: false });
      }
    } else {
      let counterr = 0;
      if (this.state.slideIndex < 2) {
        counterr = this.state.slideIndex + 1;
        this.setState({ slideIndex: counterr, loading: false });
      } else {
        this.setState({ slideIndex: 0, loading: false });
      }
    }
  };

  render() {
    const sliding = {
      transform: `translateX(${this.state.slideIndex * -100}vw)`,
    };

    return (
      <div className="SliderContainer">
        <div
          className="SliderArrow"
          style={{ left: "10px", zIndex: 5, alignItems: "center" }}
          onClick={() => this.handleClick("left")}
        >
          <img
            style={{ height: "20px" }}
            src="/assets/img/left-arrow.png"
            alt="arrow-button"
          />
        </div>

        {sliderItems.map((item) => (
          <div className="SliderWrapper" key={item.id} style={sliding}>
            <div
              className="Slide"
              style={{ backgroundColor: item.backgroundColor }}
            >
              <div className="SliderImageContainer">
                <img className="SliderImage" src={item.image}></img>
              </div>

              <div className="SliderInfoContainer">
                <h1 className="SliderTitle">{item.title}</h1>
                <p className="SliderDesc">{item.description}</p>
              </div>
            </div>
          </div>
        ))}

        <div
          className="SliderArrow"
          style={{
            right: "10px",
            zIndex: 5,
            alignItems: "center",
          }}
          onClick={this.handleClick}
        >
          <img
            style={{ height: "20px" }}
            src="/assets/img/right-arrow.png"
            alt="arrow-button"
          />
        </div>
      </div>
    );
  }
}
