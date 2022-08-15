import React from "react";
import { useNavigate } from "react-router-dom";
import "../book/styleBookCards.css";
import { categories2 } from "../datas/DataRelatedToCategoriesAndTheSlider";

export const HiddenCategoriesList = () => {
  const navigate = useNavigate();
  return (
    <>
      {categories2.map((item) => (
        <div
          key={item.id}
          onClick={() => navigate(`/books/${item.title.toLowerCase()}`)}
          className="Container img-hover-zoom img-hover-zoom--quick-zoom"
          id="secondLinePad"
        >
          <>
            <img className="Image" src={item.img}></img>
            <div className="Info">
              <h1 className="Title">{item.title}</h1>
            </div>
          </>
        </div>
      ))}
    </>
  );
};
