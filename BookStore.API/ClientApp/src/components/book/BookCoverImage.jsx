import React from "react";
import { Wrapper } from "../ui/Wrapper";

import "./styleBookCards.css";

export const BookCoverImage = ({ image }) => {
  return (
    <Wrapper className="image-wrapper">
      <img className="book-cover-image" src={image} alt={image} />
    </Wrapper>
  );
};
