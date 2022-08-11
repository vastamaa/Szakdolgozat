import React from "react";
import { HiddenCategoriesList } from "./lists/HiddenCategoriesList";
import { ShowMoreList } from "./lists/ShowMoreList";
import { VisibleCategoriesList } from "./lists/VisibleCategoriesList";
import "./styleCate.css";

export const Categories = () => {

    return (
        <div>
            <div className="BigContainer">
                <VisibleCategoriesList />
            </div>
            <div className="BigContainer secondlinehide" id="secondLine">
                <HiddenCategoriesList />
            </div>
            <ShowMoreList />
        </div>
        );
}