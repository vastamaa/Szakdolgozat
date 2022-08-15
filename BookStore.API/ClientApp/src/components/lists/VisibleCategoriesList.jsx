import React from "react";
import { useNavigate } from "react-router-dom";
import "../book/styleBookCards.css";
import { categories } from "../datas/DataRelatedToCategoriesAndTheSlider";

export const VisibleCategoriesList = () => {
  const navigate = useNavigate();
  return (
    <>
      {categories.map((item) => (
        <div
          key={item.id}
          onClick={() => navigate(`/books/${item.title.toLowerCase()}`)}
          className="Container img-hover-zoom img-hover-zoom--quick-zoom"
        >
          <>
            <img key={item.id} className="Image" src={item.img}></img>
            <div className="Info">
              <h1 className="Title">{item.title}</h1>
            </div>
          </>
        </div>
      ))}
    </>
  );
};
