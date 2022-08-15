import React from "react";
import "../book/styleBookCards.css";
import { showmore } from "../datas/DataRelatedToCategoriesAndTheSlider";

export const ShowMoreList = () => {
  const showMore = () => {
    const showMore = document.getElementById("showmorecategory");
    const tiles = document.getElementById("secondLine");
    showMore.classList.add("showmorebye");
    tiles.classList.add("secondLineHello");
  };

  return (
    <>
      {showmore.map((item) => (
        <div
          key={item.id}
          className="showmoreCategory "
          id="showmorecategory"
          onClick={showMore}
        >
          <>
            <div className="showmore-img-hover-zoom showmore-img-hover-zoom--quick-zoom showmoreBorder">
              <img
                className="showmoreImage"
                style={{ backgroundImage: `url(${item.image})` }}
              />
              <div className="showmoreInfo">
                <div className="showmoreText">{item.text}</div>
              </div>
            </div>
          </>
        </div>
      ))}
    </>
  );
};
