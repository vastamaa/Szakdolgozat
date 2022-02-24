import React, { Component } from 'react';
import { Slider } from "./Slider";
import { Categories } from './Categories';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <Slider></Slider>
                <Categories></Categories>
            </div>
        );
    }
}
