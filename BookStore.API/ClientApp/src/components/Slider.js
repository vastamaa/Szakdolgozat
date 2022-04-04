import React, { Component } from 'react';
import { sliderItems } from './Data';
import { AiOutlineRight } from "@react-icons/all-files/ai/AiOutlineRight";
import { AiOutlineLeft } from "@react-icons/all-files/ai/AiOutlineLeft";
import "./styleSlider.css"

export class Slider extends Component {
    static displayName = Slider.name;

    constructor(props) {
        super(props);
        this.state = { slideIndex: 0, loading: true };
    }
    handleClick = (direction) => {
        if (direction === "left") {
            let counter = 0;
            counter = this.state.slideIndex - 1;
            if (this.state.slideIndex > 0) {
                this.setState({ slideIndex: counter, loading: false });
            }
            else {
                this.setState({ slideIndex: 2, loading: false });
            }
        }
        else {
            let counterr = 0;

            if (this.state.slideIndex < 2) {
                counterr = this.state.slideIndex + 1;
                this.setState({ slideIndex: counterr, loading: false });
            }
            else {
                this.setState({ slideIndex: 0, loading: false });
            }
        }
    }

    render() {
        const sliding = {
            transform: `translateX(${this.state.slideIndex * -100}vw)`
        };
        return (

            <div className='SliderContainer'>
                <div className='SliderArrow' direction="left" style={{ left: "10px", zIndex: 5 }} onClick={this.handleClick}>
                    <AiOutlineLeft></AiOutlineLeft>
                </div>


                {sliderItems.map((item) => (
                    <div className='SliderWrapper' style={sliding}>
                        <div className='Slide' style={{ backgroundColor: item.bg }}>

                            <div className='SliderImageContainer' src={item.img}>
                                <img className='SliderImage' src={item.img}></img>
                            </div>

                            <div className='SliderInfoContainer'>
                                <h1 className='SliderTitle'>{item.title}</h1>
                                <p className='SliderDesc'>{item.desc}</p>
                            </div>
                        </div>
                    </div>
                ))}


                <div className='SliderArrow' direction="right" style={{ right: "10px", zIndex: 5 }} onClick={this.handleClick}>
                    <AiOutlineRight></AiOutlineRight>
                </div>
            </div>
        );
    }
}